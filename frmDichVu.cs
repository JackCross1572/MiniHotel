using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class frmDichVu : Form
    {
        bool _dangNap;

        public frmDichVu()
        {
            InitializeComponent();

            Load += frmDichVu_Load;
            FormClosed += frmDichVu_FormClosed;
            cboDatPhong.SelectedIndexChanged += cboDatPhong_SelectedIndexChanged;
            btnThemDV.Click += btnThemDV_Click;
            btnXoaDV.Click += btnXoaDV_Click;
            chkTraTre.CheckedChanged += chkTraTre_CheckedChanged;
            btnTraPhong.Click += btnTraPhong_Click;
            btnXuatHD.Click += btnXuatHD_Click;
            dgvDanhMuc.SelectionChanged += dgvDanhMuc_SelectionChanged;
            btnThemDM.Click += btnThemDM_Click;
            btnSuaDM.Click += btnSuaDM_Click;
            btnXoaDM.Click += btnXoaDM_Click;
        }

        private static string Tien(decimal v)
        {
            return v.ToString("N0") + "đ";
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            TaoCot();
            chkTraTre.Text = "Trả sau " + BillService.GioTraPhong() + "h";   // lấy từ App.config

            sfdHoaDon.Filter = "Tệp văn bản (*.txt)|*.txt";
            sfdHoaDon.DefaultExt = "txt";
            sfdHoaDon.Title = "Xuất hóa đơn";
            sfdHoaDon.OverwritePrompt = true;

            LamMoiDuLieu();
            ChonDonMoi();
            DataStore.Changed += LamMoiDuLieu;   // dữ liệu đổi ở đâu cũng tự cập nhật
        }

        private void frmDichVu_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStore.Changed -= LamMoiDuLieu;
        }

        private void TaoCot()
        {
            lvSuDung.Columns.Clear();
            lvSuDung.Columns.Add("Dịch vụ", 260);
            lvSuDung.Columns.Add("Đơn giá", 120, HorizontalAlignment.Right);
            lvSuDung.Columns.Add("SL", 70, HorizontalAlignment.Right);
            lvSuDung.Columns.Add("Thành tiền", 140, HorizontalAlignment.Right);

            dgvDanhMuc.Columns.Clear();
            dgvDanhMuc.Columns.Add("colMaDV", "Mã");
            dgvDanhMuc.Columns.Add("colTenDV", "Tên dịch vụ");
            dgvDanhMuc.Columns.Add("colGiaDV", "Đơn giá");
            dgvDanhMuc.Columns[0].FillWeight = 15;
            dgvDanhMuc.Columns[1].FillWeight = 55;
            dgvDanhMuc.Columns[2].FillWeight = 30;
            dgvDanhMuc.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void LamMoiDuLieu()
        {
            _dangNap = true;
            try
            {
                NapDatPhong();
                NapDichVu();
                NapDanhMuc();
            }
            finally { _dangNap = false; }
            CapNhatTheoDon();
            HienDanhMucDangChon();
        }

        // ---------- Tab 1: ghi dịch vụ và trả phòng ----------
        private DatPhong DonChon()
        {
            string ma = cboDatPhong.SelectedValue as string;
            if (ma == null) return null;
            return DataStore.Dats.FirstOrDefault(d => d.Ma == ma && d.TrangThai == "DangO");
        }

        private void NapDatPhong()
        {
            string cu = cboDatPhong.SelectedValue as string;
            var ds = DataStore.Dats
                .Where(d => d.TrangThai == "DangO")
                .OrderBy(d => d.SoPhong)
                .Select(d =>
                {
                    Khach k = DataStore.Khachs.FirstOrDefault(x => x.CCCD == d.CCCD);
                    return new { Ma = d.Ma, Ten = d.Ma + " - P." + d.SoPhong + " - " + (k == null ? d.CCCD : k.HoTen) };
                }).ToList();

            cboDatPhong.DataSource = null;
            cboDatPhong.DisplayMember = "Ten";
            cboDatPhong.ValueMember = "Ma";
            cboDatPhong.DataSource = ds;
            if (cu != null && ds.Any(x => x.Ma == cu)) cboDatPhong.SelectedValue = cu;
        }

        private void NapDichVu()
        {
            string cu = cboDichVu.SelectedValue as string;
            var ds = DataStore.DichVus
                .Select(v => new { Ma = v.Ma, Ten = v.Ten + " - " + v.Gia.ToString("N0") + "đ" })
                .ToList();

            cboDichVu.DataSource = null;
            cboDichVu.DisplayMember = "Ten";
            cboDichVu.ValueMember = "Ma";
            cboDichVu.DataSource = ds;
            if (cu != null && ds.Any(x => x.Ma == cu)) cboDichVu.SelectedValue = cu;
        }

        private void cboDatPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            ChonDonMoi();
        }

        // Chọn đơn khác: tự tích "Trả sau 12h" nếu bây giờ đã quá giờ trả phòng
        private void ChonDonMoi()
        {
            _dangNap = true;
            chkTraTre.Checked = DateTime.Now.Hour >= BillService.GioTraPhong();
            _dangNap = false;
            CapNhatTheoDon();
        }

        private void CapNhatTheoDon()
        {
            bool co = DonChon() != null;
            btnThemDV.Enabled = co;
            btnXoaDV.Enabled = co;
            btnTraPhong.Enabled = co;
            btnXuatHD.Enabled = co;
            NapSuDung();
            TinhHoaDon();
        }

        private void NapSuDung()
        {
            lvSuDung.BeginUpdate();
            lvSuDung.Items.Clear();
            DatPhong d = DonChon();
            if (d != null)
            {
                foreach (SuDungDV s in DataStore.SuDungs.Where(x => x.MaDat == d.Ma).OrderBy(x => x.Ngay))
                {
                    DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == s.MaDV);
                    decimal gia = v == null ? 0 : v.Gia;
                    ListViewItem it = new ListViewItem(v == null ? s.MaDV : v.Ten);
                    it.SubItems.Add(gia.ToString("N0"));
                    it.SubItems.Add(s.SoLuong.ToString());
                    it.SubItems.Add((gia * s.SoLuong).ToString("N0"));
                    it.Tag = s;
                    lvSuDung.Items.Add(it);
                }
            }
            lvSuDung.EndUpdate();
        }

        private void TinhHoaDon()
        {
            DatPhong d = DonChon();
            if (d == null)
            {
                lblTienPhongTen.Text = "Tiền phòng";
                lblTienPhong.Text = "0đ";
                lblTienDV.Text = "0đ";
                lblPhuThu.Text = "0đ";
                lblTong.Text = "0đ";
                return;
            }
            DateTime ngayTra = DateTime.Today;
            int dem = BillService.SoDem(d, ngayTra);
            decimal tienPhong = BillService.TienPhong(d, ngayTra);
            decimal tienDV = BillService.TienDichVu(d.Ma);
            decimal phuThu = chkTraTre.Checked ? BillService.PhuThuTre(d) : 0;

            lblTienPhongTen.Text = "Tiền phòng (" + dem + " đêm)";
            lblTienPhong.Text = Tien(tienPhong);
            lblTienDV.Text = Tien(tienDV);
            lblPhuThu.Text = Tien(phuThu);
            lblTong.Text = Tien(tienPhong + tienDV + phuThu);
        }

        private void chkTraTre_CheckedChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            TinhHoaDon();
        }

        private void btnThemDV_Click(object sender, EventArgs e)
        {
            errDV.Clear();
            DatPhong d = DonChon();
            if (d == null)
            {
                errDV.SetError(cboDatPhong, "Chọn một đặt phòng đang ở");
                return;
            }
            string maDV = cboDichVu.SelectedValue as string;
            if (maDV == null)
            {
                errDV.SetError(cboDichVu, "Chọn một dịch vụ (hãy thêm dịch vụ ở tab Danh mục dịch vụ)");
                return;
            }
            int sl = (int)nudSL.Value;
            if (sl <= 0)
            {
                errDV.SetError(nudSL, "Số lượng phải lớn hơn 0");
                return;
            }
            try
            {
                // Cùng dịch vụ, cùng ngày thì cộng dồn số lượng
                SuDungDV s = DataStore.SuDungs.FirstOrDefault(x => x.MaDat == d.Ma
                    && x.MaDV == maDV && x.Ngay.Date == DateTime.Today);
                if (s != null) s.SoLuong += sl;
                else DataStore.SuDungs.Add(new SuDungDV { MaDat = d.Ma, MaDV = maDV, SoLuong = sl, Ngay = DateTime.Today });

                DataStore.SaveSuDung();
                nudSL.Value = 1;
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "ThemDichVu");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            if (lvSuDung.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hãy chọn một dòng dịch vụ để xóa.", "Xóa dòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SuDungDV s = lvSuDung.SelectedItems[0].Tag as SuDungDV;
            if (s == null) return;
            try
            {
                DataStore.SuDungs.Remove(s);
                DataStore.SaveSuDung();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XoaDichVu");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null)
            {
                MessageBox.Show("Chưa có đặt phòng nào đang ở để trả.", "Trả phòng",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            decimal tienPhong = BillService.TienPhong(d, DateTime.Today);
            decimal tienDV = BillService.TienDichVu(d.Ma);
            decimal phuThu = chkTraTre.Checked ? BillService.PhuThuTre(d) : 0;
            decimal tong = tienPhong + tienDV + phuThu;

            if (MessageBox.Show("Trả phòng " + d.SoPhong + "?" + Environment.NewLine +
                "Tổng thanh toán: " + Tien(tong), "Trả phòng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            try
            {
                d.NgayDi = DateTime.Today;        // ngày trả thực tế, để hóa đơn và thống kê đúng
                d.PhuThu = phuThu;
                d.TrangThai = "DaTra";

                Phong p = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == d.SoPhong);
                if (p != null) p.TrangThai = "DangDon";

                DataStore.SaveDat();
                DataStore.SavePhong();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "TraPhong");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Đã trả phòng. Xuất hóa đơn ra tập tin TXT?", "Trả phòng",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                XuatHoaDon(d);
        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            DatPhong d = DonChon();
            if (d == null) return;
            XuatHoaDon(d);
        }

        private void XuatHoaDon(DatPhong d)
        {
            sfdHoaDon.FileName = "HoaDon_" + d.Ma + ".txt";
            if (sfdHoaDon.ShowDialog() != DialogResult.OK) return;
            try
            {
                File.WriteAllText(sfdHoaDon.FileName, NoiDungHoaDon(d), Encoding.UTF8);
                MessageBox.Show("Đã xuất hóa đơn:" + Environment.NewLine + sfdHoaDon.FileName,
                    "Xuất hóa đơn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XuatHoaDon");
                MessageBox.Show("Không ghi được tập tin hóa đơn.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NoiDungHoaDon(DatPhong d)
        {
            bool daTra = d.TrangThai == "DaTra";
            DateTime ngayTra = daTra ? d.NgayDi : DateTime.Today;
            decimal phuThu = daTra ? d.PhuThu : (chkTraTre.Checked ? BillService.PhuThuTre(d) : 0);
            Khach k = DataStore.Khachs.FirstOrDefault(x => x.CCCD == d.CCCD);
            LoaiPhong l = BillService.LoaiCuaPhong(d.SoPhong);
            var ct = BillService.ChiTietTienPhong(d, ngayTra);
            decimal tienPhong = ct.Sum(r => r.ThanhTien);

            StringBuilder sb = new StringBuilder();
            string vach = new string('-', 54);
            sb.AppendLine("KHÁCH SẠN MINIHOTEL");
            sb.AppendLine(daTra ? "HÓA ĐƠN THANH TOÁN" : "HÓA ĐƠN TẠM TÍNH");
            sb.AppendLine(vach);
            sb.AppendLine("Mã đặt phòng : " + d.Ma);
            sb.AppendLine("Khách hàng   : " + (k == null ? "" : k.HoTen));
            sb.AppendLine("CCCD         : " + d.CCCD);
            sb.AppendLine("Phòng        : " + d.SoPhong + (l == null ? "" : " (" + l.Ten + ")"));
            sb.AppendLine("Ngày đến     : " + d.NgayDen.ToString("dd/MM/yyyy"));
            sb.AppendLine("Ngày trả     : " + ngayTra.ToString("dd/MM/yyyy"));
            sb.AppendLine("Ngày lập     : " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine(vach);

            sb.AppendLine("Tiền phòng:");
            foreach (DongPhong r in ct)
            {
                string ghi = "  Phòng " + r.SoPhong + ": " + r.SoDem + " đêm";
                if (r.DemCuoiTuan > 0) ghi += " (" + r.DemCuoiTuan + " đêm cuối tuần)";
                sb.AppendLine(ghi.PadRight(40) + Tien(r.ThanhTien).PadLeft(14));
            }
            sb.AppendLine("Cộng tiền phòng: " + Tien(tienPhong));

            sb.AppendLine("Dịch vụ:");
            decimal tienDV = 0;
            bool coDV = false;
            foreach (SuDungDV s in DataStore.SuDungs.Where(x => x.MaDat == d.Ma))
            {
                DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == s.MaDV);
                decimal tt = (v == null ? 0 : v.Gia) * s.SoLuong;
                tienDV += tt;
                coDV = true;
                sb.AppendLine("  " + (v == null ? s.MaDV : v.Ten).PadRight(22)
                    + ("x" + s.SoLuong).PadRight(5) + Tien(tt).PadLeft(14));
            }
            if (!coDV) sb.AppendLine("  (không có)");
            sb.AppendLine("Tiền dịch vụ: " + Tien(tienDV));
            sb.AppendLine("Phụ thu trả trễ: " + Tien(phuThu));
            sb.AppendLine(vach);
            sb.AppendLine("TỔNG CỘNG: " + Tien(tienPhong + tienDV + phuThu));
            return sb.ToString();
        }

        // ---------- Tab 2: danh mục dịch vụ ----------
        private void NapDanhMuc()
        {
            string maCu = dgvDanhMuc.CurrentRow == null ? null : Convert.ToString(dgvDanhMuc.CurrentRow.Cells[0].Value);
            dgvDanhMuc.Rows.Clear();
            foreach (DichVu v in DataStore.DichVus)
                dgvDanhMuc.Rows.Add(v.Ma, v.Ten, v.Gia.ToString("N0"));

            if (maCu != null)
            {
                foreach (DataGridViewRow r in dgvDanhMuc.Rows)
                {
                    if (Convert.ToString(r.Cells[0].Value) == maCu)
                    {
                        dgvDanhMuc.CurrentCell = r.Cells[0];
                        r.Selected = true;
                        break;
                    }
                }
            }
        }

        private void dgvDanhMuc_SelectionChanged(object sender, EventArgs e)
        {
            if (_dangNap) return;
            HienDanhMucDangChon();
        }

        private void HienDanhMucDangChon()
        {
            if (dgvDanhMuc.CurrentRow == null) return;
            string ma = Convert.ToString(dgvDanhMuc.CurrentRow.Cells[0].Value);
            DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == ma);
            if (v == null) return;
            txtTenDV.Text = v.Ten;
            nudGiaDV.Value = Math.Min(nudGiaDV.Maximum, v.Gia);
        }

        private string MaDVMoi()
        {
            int max = 0;
            foreach (DichVu v in DataStore.DichVus)
            {
                int n;
                if (v.Ma != null && v.Ma.Length > 2 && int.TryParse(v.Ma.Substring(2), out n) && n > max)
                    max = n;
            }
            return "DV" + (max + 1).ToString("00");
        }

        // Kiểm tra tên và giá, boQuaMa là mã đang sửa (không tính trùng với chính nó)
        private bool HopLe(string ten, string boQuaMa)
        {
            errDV.Clear();
            if (ten == "")
            {
                errDV.SetError(txtTenDV, "Nhập tên dịch vụ");
                txtTenDV.Focus();
                return false;
            }
            if (ten.Contains(";"))
            {
                errDV.SetError(txtTenDV, "Không dùng dấu ; (dấu này dùng để ngăn cột trong tập tin)");
                return false;
            }
            if (nudGiaDV.Value <= 0)
            {
                errDV.SetError(nudGiaDV, "Đơn giá phải lớn hơn 0");
                return false;
            }
            if (DataStore.DichVus.Any(v => v.Ma != boQuaMa
                && string.Equals(v.Ten, ten, StringComparison.OrdinalIgnoreCase)))
            {
                errDV.SetError(txtTenDV, "Tên dịch vụ đã tồn tại");
                return false;
            }
            return true;
        }

        private void btnThemDM_Click(object sender, EventArgs e)
        {
            string ten = txtTenDV.Text.Trim();
            if (!HopLe(ten, null)) return;
            try
            {
                DataStore.DichVus.Add(new DichVu { Ma = MaDVMoi(), Ten = ten, Gia = nudGiaDV.Value });
                DataStore.SaveDichVu();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "ThemDanhMuc");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaDM_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dịch vụ trong bảng trước.", "Sửa dịch vụ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma = Convert.ToString(dgvDanhMuc.CurrentRow.Cells[0].Value);
            DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == ma);
            if (v == null) return;

            string ten = txtTenDV.Text.Trim();
            if (!HopLe(ten, ma)) return;
            try
            {
                v.Ten = ten;
                v.Gia = nudGiaDV.Value;
                DataStore.SaveDichVu();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "SuaDanhMuc");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaDM_Click(object sender, EventArgs e)
        {
            if (dgvDanhMuc.CurrentRow == null)
            {
                MessageBox.Show("Hãy chọn một dịch vụ trong bảng trước.", "Xóa dịch vụ",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string ma = Convert.ToString(dgvDanhMuc.CurrentRow.Cells[0].Value);
            DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == ma);
            if (v == null) return;

            if (DataStore.SuDungs.Any(s => s.MaDV == ma))
            {
                MessageBox.Show("Dịch vụ \"" + v.Ten + "\" đã được khách sử dụng, không thể xóa.",
                    "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Xóa dịch vụ \"" + v.Ten + "\"?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
            try
            {
                DataStore.DichVus.Remove(v);
                DataStore.SaveDichVu();
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XoaDanhMuc");
                MessageBox.Show("Không lưu được dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}