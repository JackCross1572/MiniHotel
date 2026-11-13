using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmTrangChu : Form
    {
        const int GIO_NHAC = 11;   // từ 11h ngày đi thì nhắc trả phòng (đổi thành 0 để thử)

        public frmTrangChu()
        {
            InitializeComponent();

            Load += frmTrangChu_Load;
            FormClosed += frmTrangChu_FormClosed;
            tmrNhac.Tick += tmrNhac_Tick;
            ctxPhong.Opening += ctxPhong_Opening;
            ctxDatPhong.Click += ctxDatPhong_Click;
            ctxNhanPhong.Click += ctxNhanPhong_Click;
            ctxTraPhong.Click += ctxTraPhong_Click;
            ctxDangDon.Click += ctxDangDon_Click;
            ctxTrong.Click += ctxTrong_Click;
        }

        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            TaoIcon();
            lvPhong.LargeImageList = imgPhong;
            DataStore.Changed += VeSoDo;       // dữ liệu đổi ở đâu cũng tự vẽ lại
            VeSoDo();
            tmrNhac_Tick(null, null);
        }

        private void frmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStore.Changed -= VeSoDo;       // bắt buộc hủy đăng ký khi đóng
        }

        // 3 icon: xanh (trống), đỏ (có khách), vàng (đang dọn)
        private void TaoIcon()
        {
            Color[] mau = {
                Color.FromArgb(46, 139, 87),
                Color.FromArgb(205, 92, 92),
                Color.FromArgb(218, 165, 32)
            };
            imgPhong.ImageSize = new Size(48, 48);
            imgPhong.ColorDepth = ColorDepth.Depth32Bit;
            imgPhong.Images.Clear();
            foreach (Color c in mau)
            {
                Bitmap bmp = new Bitmap(48, 48);
                using (Graphics g = Graphics.FromImage(bmp))
                using (SolidBrush b = new SolidBrush(c))
                {
                    g.Clear(Color.Transparent);
                    g.FillRectangle(b, 4, 8, 40, 32);
                }
                imgPhong.Images.Add(bmp);
            }
        }

        private void VeSoDo()
        {
            string dangChon = lvPhong.SelectedItems.Count > 0 ? lvPhong.SelectedItems[0].Text : null;

            lvPhong.BeginUpdate();
            lvPhong.Items.Clear();
            lvPhong.Groups.Clear();
            foreach (var tang in DataStore.Phongs.GroupBy(p => p.Tang).OrderBy(g => g.Key))
            {
                ListViewGroup grp = new ListViewGroup("Tầng " + tang.Key);
                lvPhong.Groups.Add(grp);
                foreach (Phong p in tang.OrderBy(x => x.SoPhong))
                {
                    int img = p.TrangThai == "Trong" ? 0 : (p.TrangThai == "CoKhach" ? 1 : 2);
                    ListViewItem it = new ListViewItem(p.SoPhong, img);
                    it.Group = grp;
                    it.Tag = p;
                    it.Selected = (p.SoPhong == dangChon);
                    lvPhong.Items.Add(it);
                }
            }
            lvPhong.EndUpdate();
            CapNhatThe();
        }

        private void CapNhatThe()
        {
            lblSoTrong.Text = DataStore.Phongs.Count(p => p.TrangThai == "Trong").ToString();
            lblSoCoKhach.Text = DataStore.Phongs.Count(p => p.TrangThai == "CoKhach").ToString();
            lblSoDangDon.Text = DataStore.Phongs.Count(p => p.TrangThai == "DangDon").ToString();
            decimal dt = DataStore.Dats
    .Where(d => d.TrangThai == "DaTra" && d.NgayDi.Date == DateTime.Today)
    .Sum(d => BillService.TongDaTra(d));
            lblDoanhThu.Text = dt.ToString("N0") + "đ";
        }

        // Nhắc phòng sắp đến giờ trả
        private void tmrNhac_Tick(object sender, EventArgs e)
        {
            var ds = DataStore.Dats.Where(d => d.TrangThai == "DangO"
                        && d.NgayDi.Date == DateTime.Today
                        && DateTime.Now.Hour >= GIO_NHAC).ToList();
            if (ds.Count == 0)
            {
                lblNhac.Visible = false;
                return;
            }
            lblNhac.Text = "Phòng " + string.Join(", ", ds.Select(d => d.SoPhong).ToArray())
                         + " sắp đến giờ trả phòng";
            lblNhac.Visible = true;
        }

        // ---------- Menu chuột phải ----------
        private Phong PhongChon()
        {
            if (lvPhong.SelectedItems.Count == 0) return null;
            return lvPhong.SelectedItems[0].Tag as Phong;
        }

        // Đơn đã đặt, đến hạn nhận phòng hôm nay
        private DatPhong DonCanNhan(string soPhong)
        {
            return DataStore.Dats.FirstOrDefault(d => d.SoPhong == soPhong
                && d.TrangThai == "DaDat"
                && d.NgayDen.Date <= DateTime.Today
                && d.NgayDi.Date > DateTime.Today);
        }

        private void ctxPhong_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Phong p = PhongChon();
            if (p == null) { e.Cancel = true; return; }   // bấm phải ra chỗ trống thì không hiện menu

            ctxDatPhong.Enabled = p.TrangThai == "Trong";
            ctxNhanPhong.Enabled = p.TrangThai == "Trong" && DonCanNhan(p.SoPhong) != null;
            ctxTraPhong.Enabled = p.TrangThai == "CoKhach";
            ctxDangDon.Enabled = p.TrangThai != "DangDon";
            ctxTrong.Enabled = p.TrangThai == "DangDon";
        }

        private void ctxDatPhong_Click(object sender, EventArgs e)
        {
            frmMain m = MdiParent as frmMain;
            if (m != null) m.MoDatPhong();
        }

        private void ctxNhanPhong_Click(object sender, EventArgs e)
        {
            Phong p = PhongChon();
            if (p == null) return;
            DatPhong don = DonCanNhan(p.SoPhong);
            if (don == null) return;
            try
            {
                don.TrangThai = "DangO";
                p.TrangThai = "CoKhach";
                DataStore.SaveDat();
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "NhanPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxTraPhong_Click(object sender, EventArgs e)
        {
            frmMain m = MdiParent as frmMain;
            if (m != null) m.MoDichVu();
        }

        private void DoiTrangThai(string moi)
        {
            Phong p = PhongChon();
            if (p == null) return;
            try
            {
                p.TrangThai = moi;
                DataStore.SavePhong();   // lưu file rồi RaiseChanged() => sơ đồ tự vẽ lại
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "DoiTrangThai");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctxDangDon_Click(object sender, EventArgs e) { DoiTrangThai("DangDon"); }
        private void ctxTrong_Click(object sender, EventArgs e) { DoiTrangThai("Trong"); }
    }
}