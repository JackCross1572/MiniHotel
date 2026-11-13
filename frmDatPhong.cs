using System;
using System.Drawing;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmDatPhong : Form
    {
        static readonly string[] MaLoc = { "", "DaDat", "DangO", "DaTra", "Huy", "An" };
        bool _dangNap;
        string _phongChon;

        public frmDatPhong()
        {
            InitializeComponent();

            Load += frmDatPhong_Load;
            FormClosed += frmDatPhong_FormClosed;
            btnTim.Click += btnTim_Click;
            btnXacNhan.Click += btnXacNhan_Click;
            dtpDen.ValueChanged += dtp_ValueChanged;
            dtpDi.ValueChanged += dtp_ValueChanged;
            cboLoai.SelectedIndexChanged += cboLoai_SelectedIndexChanged;
            txtTim.TextChanged += LocDanhSach;
            cboLoc.SelectedIndexChanged += LocDanhSach;
            lvDat.SelectedIndexChanged += lvDat_SelectedIndexChanged;
            btnNhanPhong.Click += btnNhanPhong_Click;
            btnHuyDat.Click += btnHuyDat_Click;
            txtCCCD.TextChanged += txtCCCD_TextChanged;
            btnDoiPhong.Click += btnDoiPhong_Click;
            btnXoaDon.Click += btnXoaDon_Click;
        }

        private void frmDatPhong_Load(object sender, EventArgs e)
        {
            _dangNap = true;
            try
            {
                TaoCot();

                cboLoc.Items.Clear();
                cboLoc.Items.AddRange(new object[] { "Tất cả", "Đã đặt", "Đang ở", "Đã trả", "Đã hủy", "Đã xóa" });
                cboLoc.SelectedIndex = 0;

                dtpDen.Format = DateTimePickerFormat.Custom;
                dtpDen.CustomFormat = "dd/MM/yyyy";
                dtpDi.Format = DateTimePickerFormat.Custom;
                dtpDi.CustomFormat = "dd/MM/yyyy";
                dtpDen.MinDate = DateTime.Today;
                dtpDen.Value = DateTime.Today;
                dtpDi.MinDate = DateTime.Today.AddDays(1);
                dtpDi.Value = DateTime.Today.AddDays(1);

                NapLoai();
            }
            finally { _dangNap = false; }

            lblLoi.Text = "";
            NapDanhSach();
            DataStore.Changed += LamMoiDuLieu;   // dữ liệu đổi ở đâu cũng tự cập nhật
        }

        private void frmDatPhong_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStore.Changed -= LamMoiDuLieu;
        }

        private void TaoCot()
        {
            lvDat.Columns.Clear();
            lvDat.Columns.Add("Mã", 70);
            lvDat.Columns.Add("Họ tên", 170);
            lvDat.Columns.Add("CCCD", 120);
            lvDat.Columns.Add("SĐT", 100);
            lvDat.Columns.Add("Phòng", 70);
            lvDat.Columns.Add("Loại", 90);
            lvDat.Columns.Add("Đến", 90);
            lvDat.Columns.Add("Đi", 90);
            lvDat.Columns.Add("Số đêm", 70, HorizontalAlignment.Right);
            lvDat.Columns.Add("Trạng thái", 100);
        }

        private void NapLoai()
        {
            cboLoai.DataSource = null;
            cboLoai.DisplayMember = "Ten";
            cboLoai.ValueMember = "Ma";
            cboLoai.DataSource = DataStore.Loais
                .Select(l => new { Ma = l.Ma, Ten = l.Ten + " - " + l.GiaNgay.ToString("N0") + "đ" })
                .ToList();
        }

        private void LamMoiDuLieu()
        {
            _dangNap = true;
            try
            {
                object cu = cboLoai.SelectedValue;
                NapLoai();
                if (cu != null) cboLoai.SelectedValue = cu;
            }
            finally { _dangNap = false; }
            XoaPhongTrong();          // trạng thái phòng có thể vừa đổi ở form khác: bắt buộc tìm lại
            NapDanhSach();
        }

        private void Thong(string s, bool loi)
        {
            lblLoi.ForeColor = loi ? Color.FromArgb(178, 34, 34) : Color.FromArgb(100, 100, 100);
            lblLoi.Text = s;
        }

        private static string TenTT(string ma)
        {
            switch (ma)
            {
                case "DaDat": return "Đã đặt";
                case "DangO": return "Đang ở";
                case "DaTra": return "Đã trả";
                case "Huy": return "Đã hủy";
                default: return ma;
            }
        }

        // ---------- Đặt phòng mới ----------
        private void XoaPhongTrong()
        {
            flpPhongTrong.Controls.Clear();
            _phongChon = null;
            lblLoi.Text = "";
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            if (sender == dtpDen)
            {
                DateTime min = dtpDen.Value.Date.AddDays(1);
                dtpDi.MinDate = min;                       // ngày đi luôn sau ngày đến
                if (dtpDi.Value.Date < min) dtpDi.Value = min;
            }
            XoaPhongTrong();                               // đổi ngày thì phải tìm lại
        }

        private void cboLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            XoaPhongTrong();
        }

        private void txtCCCD_TextChanged(object sender, EventArgs e)
        {
            string c = txtCCCD.Text.Trim();
            if (c.Length != 12) return;
            Khach k = DataStore.Khachs.FirstOrDefault(x => x.CCCD == c);
            if (k == null) return;
            txtHoTen.Text = k.HoTen;     // khách cũ: tự điền họ tên và số điện thoại
            txtSDT.Text = k.SDT;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            errDat.Clear();
            lblLoi.Text = "";
            if (cboLoai.SelectedValue == null)
            {
                errDat.SetError(cboLoai, "Chọn loại phòng");
                return;
            }
            DateTime den = dtpDen.Value.Date;
            DateTime di = dtpDi.Value.Date;
            if (di <= den)
            {
                errDat.SetError(dtpDi, "Ngày đi phải sau ngày đến");
                return;
            }

            var ds = BookingService.TimPhongTrong(cboLoai.SelectedValue.ToString(), den, di);
            flpPhongTrong.Controls.Clear();
            _phongChon = null;

            if (ds.Count == 0)
            {
                Thong("Hết phòng loại này trong khoảng ngày đã chọn.", true);
                return;
            }
            foreach (Phong p in ds)
            {
                RadioButton rb = new RadioButton();
                rb.Text = p.SoPhong;
                rb.Tag = p.SoPhong;
                rb.Appearance = Appearance.Button;
                rb.AutoSize = true;
                rb.Padding = new Padding(8, 4, 8, 4);
                rb.Margin = new Padding(0, 0, 8, 4);
                rb.CheckedChanged += (s, ev) =>
                {
                    RadioButton r = (RadioButton)s;
                    if (r.Checked) _phongChon = (string)r.Tag;
                };
                flpPhongTrong.Controls.Add(rb);
            }
            string tam = "";
            LoaiPhong lp = DataStore.Loais.FirstOrDefault(x => x.Ma == cboLoai.SelectedValue.ToString());
            if (lp != null)
            {
                DongPhong r = BillService.TinhDoan(null, lp.GiaNgay, den, di);
                tam = " Tạm tính " + r.SoDem + " đêm: " + r.ThanhTien.ToString("N0") + "đ"
                    + (r.DemCuoiTuan > 0 ? " (có " + r.DemCuoiTuan + " đêm cuối tuần)" : "") + ".";
            }
            Thong("Còn " + ds.Count + " phòng trống." + tam, false);
        }

        private string MaMoi()
        {
            int max = 0;
            foreach (DatPhong d in DataStore.Dats)
            {
                int n;
                if (d.Ma != null && d.Ma.Length > 1 && int.TryParse(d.Ma.Substring(1), out n) && n > max)
                    max = n;
            }
            return "D" + (max + 1).ToString("000");
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errDat.Clear();
            string cccd = txtCCCD.Text.Trim();
            string ten = txtHoTen.Text.Trim();
            string sdt = txtSDT.Text.Trim();

            if (!Regex.IsMatch(cccd, @"^\d{12}$"))
            {
                errDat.SetError(txtCCCD, "CCCD phải đủ 12 chữ số");
                txtCCCD.Focus();
                return;
            }
            if (ten == "")
            {
                errDat.SetError(txtHoTen, "Nhập họ tên khách");
                txtHoTen.Focus();
                return;
            }
            if (ten.Contains(";"))
            {
                errDat.SetError(txtHoTen, "Không dùng dấu ; (dấu này dùng để ngăn cột trong tập tin)");
                txtHoTen.Focus();
                return;
            }
            if (sdt != "" && !Regex.IsMatch(sdt, @"^\d{9,11}$"))
            {
                errDat.SetError(txtSDT, "Số điện thoại gồm 9 đến 11 chữ số");
                txtSDT.Focus();
                return;
            }
            if (_phongChon == null)
            {
                Thong("Bấm Tìm phòng trống rồi chọn một phòng.", true);
                return;
            }

            DateTime den = dtpDen.Value.Date;
            DateTime di = dtpDi.Value.Date;
            if (di <= den)
            {
                errDat.SetError(dtpDi, "Ngày đi phải sau ngày đến");
                return;
            }
            // Kiểm tra lại lần cuối: không cho đặt trùng lịch
            if (BookingService.TrungLich(_phongChon, den, di))
            {
                XoaPhongTrong();
                Thong("Phòng vừa bị đặt trùng lịch. Hãy tìm phòng trống lại.", true);
                return;
            }

            try
            {
                string phong = _phongChon;
                string ma = MaMoi();

                Khach k = DataStore.Khachs.FirstOrDefault(x => x.CCCD == cccd);
                if (k == null) DataStore.Khachs.Add(new Khach { CCCD = cccd, HoTen = ten, SDT = sdt });
                else { k.HoTen = ten; k.SDT = sdt; }     // khách cũ: cập nhật thông tin mới nhất

                DataStore.Dats.Add(new DatPhong
                {
                    Ma = ma,
                    CCCD = cccd,
                    SoPhong = phong,
                    NgayDen = den,
                    NgayDi = di,
                    TrangThai = "DaDat"
                });
                DataStore.SaveKhach();
                DataStore.SaveDat();

                txtCCCD.Clear();
                txtHoTen.Clear();
                txtSDT.Clear();
                XoaPhongTrong();
                Thong("Đã đặt phòng " + phong + " (mã " + ma + ") thành công.", false);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "DatPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Danh sách đặt phòng ----------
        private void LocDanhSach(object sender, EventArgs e)
        {
            if (_dangNap) return;
            NapDanhSach();
        }

        private void NapDanhSach()
        {
            string chon = lvDat.SelectedItems.Count > 0 ? lvDat.SelectedItems[0].Text : null;
            string tuKhoa = txtTim.Text.Trim().ToLower();
            string tt = MaLoc[Math.Max(0, cboLoc.SelectedIndex)];

            lvDat.BeginUpdate();
            lvDat.Items.Clear();
            foreach (DatPhong d in DataStore.Dats.OrderByDescending(x => x.NgayDen).ThenByDescending(x => x.Ma))
            {
                if (tt == "An")
                {
                    if (!d.DaAn) continue;               // bộ lọc "Đã xóa": chỉ hiện các dòng đã xóa
                }
                else
                {
                    if (d.DaAn) continue;                // dòng đã xóa không hiện trong danh sách thường
                    if (tt != "" && d.TrangThai != tt) continue;
                }

                Khach k = DataStore.Khachs.FirstOrDefault(x => x.CCCD == d.CCCD);
                string hoTen = k == null ? "" : k.HoTen;
                string sdt = k == null ? "" : k.SDT;
                if (tuKhoa != "" && !(hoTen + " " + d.CCCD + " " + d.SoPhong).ToLower().Contains(tuKhoa))
                    continue;

                Phong p = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == d.SoPhong);
                LoaiPhong l = p == null ? null : DataStore.Loais.FirstOrDefault(x => x.Ma == p.MaLoai);

                ListViewItem it = new ListViewItem(d.Ma);
                it.SubItems.Add(hoTen);
                it.SubItems.Add(d.CCCD);
                it.SubItems.Add(sdt);
                it.SubItems.Add(d.SoPhong);
                it.SubItems.Add(l == null ? "" : l.Ten);
                it.SubItems.Add(d.NgayDen.ToString("dd/MM/yyyy"));
                it.SubItems.Add(d.NgayDi.ToString("dd/MM/yyyy"));
                it.SubItems.Add(BookingService.SoDem(d).ToString());
                it.SubItems.Add(TenTT(d.TrangThai));
                it.Tag = d;

                if (d.TrangThai == "DangO") it.ForeColor = Color.FromArgb(46, 139, 87);
                else if (d.TrangThai == "Huy") it.ForeColor = Color.FromArgb(178, 34, 34);
                else if (d.TrangThai == "DaTra") it.ForeColor = Color.Gray;
                else it.ForeColor = Color.FromArgb(31, 58, 95);
                if (d.DaAn) it.ForeColor = Color.Gray;

                it.Selected = (d.Ma == chon);
                lvDat.Items.Add(it);
            }
            lvDat.EndUpdate();
            CapNhatNut();
        }

        private DatPhong DonChon()
        {
            return lvDat.SelectedItems.Count == 0 ? null : lvDat.SelectedItems[0].Tag as DatPhong;
        }

        private void lvDat_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatNut();
        }

        private void CapNhatNut()
        {
            DatPhong d = DonChon();
            if (d == null)
            {
                lblChon.Text = "Chưa chọn đặt phòng";
                btnNhanPhong.Enabled = false;
                btnDoiPhong.Enabled = false;
                btnHuyDat.Enabled = false;
                btnXoaDon.Enabled = false;
                btnXoaDon.Text = "Xóa dòng";
                return;
            }
            bool daDat = d.TrangThai == "DaDat";
            lblChon.Text = "Đã chọn: " + d.Ma + " - Phòng " + d.SoPhong;
            btnHuyDat.Enabled = daDat;
            btnDoiPhong.Enabled = d.TrangThai == "DangO";
            btnNhanPhong.Enabled = daDat && d.NgayDen.Date <= DateTime.Today;
            btnXoaDon.Enabled = d.DaAn || d.TrangThai == "DaTra" || d.TrangThai == "Huy";
            btnXoaDon.Text = d.DaAn ? "Khôi phục" : "Xóa dòng";
            if (daDat && d.NgayDen.Date > DateTime.Today)
                lblChon.Text += " (chưa đến ngày nhận phòng)";
        }

        private void btnNhanPhong_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null || d.TrangThai != "DaDat") return;

            Phong p = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == d.SoPhong);
            if (p == null)
            {
                MessageBox.Show("Không tìm thấy phòng " + d.SoPhong + ".", "Nhận phòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (p.TrangThai == "CoKhach")
            {
                MessageBox.Show("Phòng " + p.SoPhong + " đang có khách (chưa trả phòng), chưa thể nhận phòng.",
                    "Nhận phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                d.TrangThai = "DangO";
                p.TrangThai = "CoKhach";
                DataStore.SaveDat();
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "NhanPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyDat_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null || d.TrangThai != "DaDat") return;

            if (MessageBox.Show("Hủy đặt phòng " + d.Ma + " (phòng " + d.SoPhong + ")?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                d.TrangThai = "Huy";
                DataStore.SaveDat();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "HuyDat");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnXoaDon_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null) return;

            try
            {
                if (d.DaAn)                                  // đang xem bộ lọc "Đã xóa": khôi phục lại
                {
                    d.DaAn = false;
                    DataStore.SaveDat();
                    return;
                }
                if (d.TrangThai != "DaTra" && d.TrangThai != "Huy")
                {
                    MessageBox.Show("Chỉ xóa được dòng Đã trả hoặc Đã hủy." + Environment.NewLine +
                        "Đơn Đã đặt: bấm Hủy đặt trước." + Environment.NewLine +
                        "Đơn Đang ở: Trả phòng ở form Dịch vụ và hóa đơn trước.",
                        "Xóa dòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (MessageBox.Show("Xóa dòng " + d.Ma + " khỏi danh sách?" + Environment.NewLine +
                    "Dữ liệu vẫn được giữ để thống kê doanh thu. Xem lại bằng bộ lọc \"Đã xóa\".",
                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

                d.DaAn = true;
                DataStore.SaveDat();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XoaDon");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnDoiPhong_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null || d.TrangThai != "DangO") return;

            DateTime homNay = DateTime.Today;
            // Phòng mới phải trống từ hôm nay đến ngày đi dự kiến (tối thiểu thêm 1 đêm)
            DateTime di = d.NgayDi.Date > homNay ? d.NgayDi.Date : homNay.AddDays(1);

            var ds = DataStore.Phongs
                .Where(p => p.SoPhong != d.SoPhong
                         && p.TrangThai == "Trong"
                         && !BookingService.TrungLich(p.SoPhong, homNay, di))
                .OrderBy(p => p.SoPhong)
                .ToList();

            if (ds.Count == 0)
            {
                MessageBox.Show("Hiện không còn phòng nào để đổi (phòng mới phải ở trạng thái Trống và không trùng lịch đặt).",
                    "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string moi = HoiPhongMoi(ds, d);
            if (moi == null) return;

            // Kiểm tra lại lần cuối: không cho đổi sang phòng bị trùng lịch
            if (BookingService.TrungLich(moi, homNay, di))
            {
                MessageBox.Show("Phòng " + moi + " vừa bị đặt trùng lịch. Hãy chọn lại.",
                    "Đổi phòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string cu = d.SoPhong;
                Phong pCu = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == cu);
                Phong pMoi = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == moi);

                DataStore.DoiPhongs.Add(new DoiPhong { MaDat = d.Ma, PhongCu = cu, NgayDoi = homNay });
                d.SoPhong = moi;
                if (d.NgayDi.Date < di) d.NgayDi = di;     // ngày đi dự kiến đã qua thì gia hạn thêm 1 đêm
                if (pCu != null) pCu.TrangThai = "DangDon";
                if (pMoi != null) pMoi.TrangThai = "CoKhach";

                DataStore.SaveDoiPhong();
                DataStore.SaveDat();
                DataStore.SavePhong();
                Thong("Đã đổi " + d.Ma + " từ phòng " + cu + " sang phòng " + moi + ".", false);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "DoiPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hộp thoại nhỏ tạo bằng code: chọn phòng mới, trả về số phòng hoặc null nếu hủy
        private string HoiPhongMoi(List<Phong> ds, DatPhong d)
        {
            using (Form f = new Form())
            {
                f.Text = "Đổi phòng " + d.SoPhong;
                f.FormBorderStyle = FormBorderStyle.FixedDialog;
                f.StartPosition = FormStartPosition.CenterParent;
                f.MaximizeBox = false;
                f.MinimizeBox = false;
                f.ShowInTaskbar = false;
                f.Font = Font;
                f.ClientSize = new Size(380, 140);

                Label lb = new Label();
                lb.Text = "Chọn phòng mới (còn trống từ hôm nay):";
                lb.Left = 16; lb.Top = 16; lb.AutoSize = true;

                ComboBox cb = new ComboBox();
                cb.Left = 16; cb.Top = 44; cb.Width = 348;
                cb.DropDownStyle = ComboBoxStyle.DropDownList;
                cb.DisplayMember = "Ten";
                cb.ValueMember = "Ma";
                cb.DataSource = ds.Select(p =>
                {
                    LoaiPhong l = BillService.LoaiCuaPhong(p.SoPhong);
                    return new
                    {
                        Ma = p.SoPhong,
                        Ten = "Phòng " + p.SoPhong + (l == null ? "" : " - " + l.Ten + " - " + l.GiaNgay.ToString("N0") + "đ/đêm")
                    };
                }).ToList();

                Button ok = new Button();
                ok.Text = "Đổi phòng"; ok.Left = 164; ok.Top = 90; ok.Width = 96; ok.Height = 34;
                ok.DialogResult = DialogResult.OK;

                Button huy = new Button();
                huy.Text = "Hủy"; huy.Left = 268; huy.Top = 90; huy.Width = 96; huy.Height = 34;
                huy.DialogResult = DialogResult.Cancel;

                f.Controls.AddRange(new Control[] { lb, cb, ok, huy });
                f.AcceptButton = ok;
                f.CancelButton = huy;

                if (f.ShowDialog(this) != DialogResult.OK) return null;
                return cb.SelectedValue as string;
            }
        }
    }
}