using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
    

    public partial class frmThongKe : Form
    {
        bool _dangNap;
        List<KyThongKe> _cacKy = new List<KyThongKe>();
        int _chon = -1;

        static readonly Color MauThuong = Color.FromArgb(120, 150, 190);
        static readonly Color MauChon = Color.FromArgb(31, 58, 95);

        public frmThongKe()
        {
            InitializeComponent();

            Load += frmThongKe_Load;
            FormClosed += frmThongKe_FormClosed;
            cboKieu.SelectedIndexChanged += LocThayDoi;
            cboNam.SelectedIndexChanged += LocThayDoi;
            cboThang.SelectedIndexChanged += LocThayDoi;
            chartDT.MouseClick += chartDT_MouseClick;
            btnXuatBC.Click += btnXuatBC_Click;
        }

        private static string Tien(decimal v)
        {
            return v.ToString("N0") + "đ";
        }

        private bool TheoTuan { get { return cboKieu.SelectedIndex == 1; } }
        private int Nam { get { return cboNam.SelectedItem == null ? DateTime.Today.Year : (int)cboNam.SelectedItem; } }
        private int Thang { get { return Math.Max(1, cboThang.SelectedIndex + 1); } }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            _dangNap = true;
            try
            {
                cboKieu.Items.Clear();
                cboKieu.Items.AddRange(new object[] { "Theo tháng", "Theo tuần" });
                cboKieu.SelectedIndex = 0;

                cboThang.Items.Clear();
                for (int m = 1; m <= 12; m++) cboThang.Items.Add("Tháng " + m);
                cboThang.SelectedIndex = DateTime.Today.Month - 1;

                NapNam();
            }
            finally { _dangNap = false; }

            CauHinhChart();
            DatLaiHienThi(true);
            DataStore.Changed += LamMoiDuLieu;   // có đơn trả phòng mới thì biểu đồ tự cập nhật
        }

        private void frmThongKe_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataStore.Changed -= LamMoiDuLieu;
        }

        // Các năm có doanh thu, cộng với năm hiện tại
        private void NapNam()
        {
            List<int> nam = DataStore.Dats.Where(d => d.TrangThai == "DaTra").Select(d => d.NgayDi.Year).ToList();
            nam.Add(DateTime.Today.Year);
            nam = nam.Distinct().OrderByDescending(x => x).ToList();

            object cu = cboNam.SelectedItem;
            cboNam.Items.Clear();
            foreach (int n in nam) cboNam.Items.Add(n);
            if (cu != null && nam.Contains((int)cu)) cboNam.SelectedItem = cu;
            else cboNam.SelectedItem = DateTime.Today.Year;
        }

        private void LamMoiDuLieu()
        {
            _dangNap = true;
            try { NapNam(); }
            finally { _dangNap = false; }
            DatLaiHienThi(false);
        }

        private void LocThayDoi(object sender, EventArgs e)
        {
            if (_dangNap) return;
            DatLaiHienThi(true);
        }

        private void DatLaiHienThi(bool chonMacDinh)
        {
            lblThang.Visible = TheoTuan;       // chỉ chế độ theo tuần mới chọn tháng
            cboThang.Visible = TheoTuan;

            TaoCacKy();
            if (chonMacDinh) _chon = KyMacDinh();
            if (_chon >= _cacKy.Count) _chon = _cacKy.Count - 1;
            VeBieuDo();
            CapNhatThe();
        }

        // ---------- Tính số liệu ----------
        private void TaoCacKy()
        {
            _cacKy.Clear();
            if (!TheoTuan)
            {
                for (int m = 1; m <= 12; m++)
                {
                    DateTime tu = new DateTime(Nam, m, 1);
                    _cacKy.Add(TinhKy("T" + m, "tháng " + m + "/" + Nam, tu, tu.AddMonths(1)));
                }
            }
            else
            {
                DateTime dau = new DateTime(Nam, Thang, 1);
                DateTime cuoi = dau.AddMonths(1);
                int stt = 1;
                for (DateTime tu = dau; tu < cuoi; tu = tu.AddDays(7))
                {
                    DateTime den = tu.AddDays(7) < cuoi ? tu.AddDays(7) : cuoi;
                    string kc = tu.Day + "-" + den.AddDays(-1).Day;
                    _cacKy.Add(TinhKy("Tuần " + stt + " (" + kc + ")",
                        "tuần " + stt + " (" + kc + "/" + Thang + ")", tu, den));
                    stt++;
                }
            }
        }

        // Kỳ chứa ngày hôm nay; nếu không có thì chọn kỳ đầu tiên
        private int KyMacDinh()
        {
            DateTime h = DateTime.Today;
            for (int i = 0; i < _cacKy.Count; i++)
                if (h >= _cacKy[i].Tu && h < _cacKy[i].Den) return i;
            return 0;
        }

        private KyThongKe TinhKy(string nhan, string moTa, DateTime tu, DateTime den)
        {
            KyThongKe k = new KyThongKe { Nhan = nhan, MoTa = moTa, Tu = tu, Den = den };

            foreach (DatPhong d in DataStore.Dats)    // gồm cả đơn đã xóa khỏi danh sách (DaAn)
            {
                // Doanh thu: đơn đã trả, tính vào kỳ chứa ngày trả phòng
                if (d.TrangThai == "DaTra" && d.NgayDi.Date >= tu && d.NgayDi.Date < den)
                {
                    k.DoanhThu += BillService.TongDaTra(d);
                    k.Luot++;
                }

                // Công suất: các đêm đã ở (đơn đã trả và đơn đang ở tính đến hôm nay)
                if (d.TrangThai == "DaTra" || d.TrangThai == "DangO")
                {
                    DateTime ketThuc = d.TrangThai == "DaTra" ? d.NgayDi.Date : DateTime.Today;
                    if (d.TrangThai == "DaTra" && ketThuc <= d.NgayDen.Date)
                        ketThuc = d.NgayDen.Date.AddDays(1);          // tối thiểu 1 đêm, khớp với hóa đơn

                    DateTime a = d.NgayDen.Date > tu ? d.NgayDen.Date : tu;
                    DateTime b = ketThuc < den ? ketThuc : den;
                    if (b > a) k.DemBan += (b - a).Days;
                }
            }

            int soPhong = DataStore.Phongs.Count;
            int soNgay = (den - tu).Days;
            if (soPhong > 0 && soNgay > 0)
                k.CongSuat = Math.Min(100m, 100m * k.DemBan / (soPhong * soNgay));
            return k;
        }

        // ---------- Biểu đồ ----------
        private void CauHinhChart()
        {
            chartDT.Series.Clear();
            chartDT.ChartAreas.Clear();
            chartDT.Legends.Clear();
            chartDT.Titles.Clear();

            ChartArea ca = new ChartArea("caDoanhThu");
            ca.AxisX.Interval = 1;
            ca.AxisX.MajorGrid.Enabled = false;
            ca.AxisY.Title = "Triệu đồng";
            ca.AxisY.LabelStyle.Format = "0.##";
            ca.AxisY.MajorGrid.LineColor = Color.FromArgb(230, 230, 230);
            chartDT.ChartAreas.Add(ca);

            Series sr = new Series("srDoanhThu");
            sr.ChartType = SeriesChartType.Column;
            sr.IsValueShownAsLabel = true;
            sr.LabelFormat = "0.0";
            chartDT.Series.Add(sr);

            Title tt = new Title("Doanh thu", Docking.Top,
                new Font("Segoe UI", 11, FontStyle.Bold), Color.FromArgb(31, 58, 95));
            tt.Name = "ttDoanhThu";
            chartDT.Titles.Add(tt);
        }

        private void VeBieuDo()
        {
            Series sr = chartDT.Series["srDoanhThu"];
            sr.Points.Clear();
            for (int i = 0; i < _cacKy.Count; i++)
            {
                int idx = sr.Points.AddXY(_cacKy[i].Nhan, (double)(_cacKy[i].DoanhThu / 1000000m));
                sr.Points[idx].Color = (i == _chon) ? MauChon : MauThuong;
            }
            chartDT.Titles["ttDoanhThu"].Text = TheoTuan
                ? "Doanh thu theo tuần - tháng " + Thang + "/" + Nam + " (triệu đồng)"
                : "Doanh thu theo tháng - năm " + Nam + " (triệu đồng)";
        }

        private void chartDT_MouseClick(object sender, MouseEventArgs e)
        {
            HitTestResult r = chartDT.HitTest(e.X, e.Y);
            if (r.ChartElementType != ChartElementType.DataPoint) return;
            _chon = r.PointIndex;
            VeBieuDo();
            CapNhatThe();
        }

        private void CapNhatThe()
        {
            decimal tong = _cacKy.Sum(x => x.DoanhThu);
            lblTenTong.Text = TheoTuan ? "Tổng doanh thu tháng " + Thang + "/" + Nam
                                       : "Tổng doanh thu năm " + Nam;
            lblTongDoanhThu.Text = Tien(tong);

            if (_chon < 0 || _chon >= _cacKy.Count)
            {
                lblTenKy.Text = "Doanh thu";
                lblDoanhThuKy.Text = "0đ";
                lblLuotTra.Text = "0";
                lblCongSuat.Text = "0%";
                return;
            }
            KyThongKe k = _cacKy[_chon];
            lblTenKy.Text = "Doanh thu " + k.MoTa;
            lblDoanhThuKy.Text = Tien(k.DoanhThu);
            lblLuotTra.Text = k.Luot.ToString();
            lblCongSuat.Text = k.CongSuat.ToString("0.0") + "%";
        }

        // ---------- Xuất báo cáo ----------
        private void btnXuatBC_Click(object sender, EventArgs e)
        {
            sfdBaoCao.Title = "Xuất báo cáo";
            sfdBaoCao.Filter = "Tệp văn bản (*.txt)|*.txt|Tệp CSV (*.csv)|*.csv";
            sfdBaoCao.FilterIndex = 1;
            sfdBaoCao.OverwritePrompt = true;
            sfdBaoCao.FileName = TheoTuan
                ? "BaoCao_Tuan_" + Nam + "_" + Thang.ToString("00")
                : "BaoCao_Thang_" + Nam;
            if (sfdBaoCao.ShowDialog() != DialogResult.OK) return;

            try
            {
                bool csv = sfdBaoCao.FilterIndex == 2
                    || sfdBaoCao.FileName.EndsWith(".csv", StringComparison.OrdinalIgnoreCase);
                File.WriteAllText(sfdBaoCao.FileName, csv ? NoiDungCsv() : NoiDungTxt(), new UTF8Encoding(true));
                MessageBox.Show("Đã xuất báo cáo:" + Environment.NewLine + sfdBaoCao.FileName,
                    "Xuất báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Logger.Write(ex, "XuatBaoCao");
                MessageBox.Show("Không ghi được tập tin báo cáo.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string NoiDungTxt()
        {
            StringBuilder sb = new StringBuilder();
            string vach = new string('-', 62);
            sb.AppendLine("KHÁCH SẠN MINIHOTEL");
            sb.AppendLine(TheoTuan
                ? "BÁO CÁO DOANH THU THEO TUẦN - THÁNG " + Thang + "/" + Nam
                : "BÁO CÁO DOANH THU THEO THÁNG - NĂM " + Nam);
            sb.AppendLine("Ngày lập: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            sb.AppendLine(vach);
            sb.AppendLine("Kỳ".PadRight(22) + "Doanh thu".PadLeft(18) + "Lượt".PadLeft(8) + "Công suất".PadLeft(14));
            sb.AppendLine(vach);
            foreach (KyThongKe k in _cacKy)
            {
                sb.AppendLine(k.Nhan.PadRight(22) + Tien(k.DoanhThu).PadLeft(18)
                    + k.Luot.ToString().PadLeft(8) + (k.CongSuat.ToString("0.0") + "%").PadLeft(14));
            }
            sb.AppendLine(vach);
            sb.AppendLine("TỔNG".PadRight(22) + Tien(_cacKy.Sum(x => x.DoanhThu)).PadLeft(18)
                + _cacKy.Sum(x => x.Luot).ToString().PadLeft(8));
            sb.AppendLine();
            sb.AppendLine("Ghi chú: doanh thu tính vào kỳ chứa ngày trả phòng; công suất = số đêm đã ở / (số phòng x số ngày của kỳ).");
            return sb.ToString();
        }

        private string NoiDungCsv()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Kỳ;Từ ngày;Đến ngày;Doanh thu;Số lượt trả phòng;Công suất (%)");
            foreach (KyThongKe k in _cacKy)
            {
                sb.AppendLine(k.Nhan + ";" + k.Tu.ToString("dd/MM/yyyy") + ";" + k.Den.AddDays(-1).ToString("dd/MM/yyyy")
                    + ";" + k.DoanhThu.ToString("0", CultureInfo.InvariantCulture)
                    + ";" + k.Luot
                    + ";" + k.CongSuat.ToString("0.0", CultureInfo.InvariantCulture));
            }
            return sb.ToString();
        }
    }
}