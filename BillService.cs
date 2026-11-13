using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace WindowsFormsApp2
{
    // Một đoạn tiền phòng: ở một phòng trong một khoảng đêm
    public class DongPhong
    {
        public string SoPhong;
        public int SoDem;
        public int DemCuoiTuan;
        public decimal ThanhTien;
    }

    public static class BillService
    {
        static decimal DocHeSo(string key, decimal macDinh)
        {
            decimal v;
            string s = ConfigurationManager.AppSettings[key];
            if (s != null && decimal.TryParse(s, NumberStyles.Number, CultureInfo.InvariantCulture, out v) && v >= 0)
                return v;
            return macDinh;
        }

        // Hệ số phụ thu trả trễ (App.config), mặc định 0.3 = 30% giá một đêm
        public static decimal HeSoPhuThu()
        {
            return DocHeSo("PhuThuTre", 0.3m);
        }

        // Hệ số giá đêm cuối tuần (App.config), mặc định 1.0 = không tăng giá
        public static decimal HeSoCuoiTuan()
        {
            decimal h = DocHeSo("HeSoCuoiTuan", 1.0m);
            return h <= 0 ? 1.0m : h;
        }

        // Giờ trả phòng chuẩn (App.config), mặc định 12
        public static int GioTraPhong()
        {
            int h;
            string s = ConfigurationManager.AppSettings["GioTraPhong"];
            if (s != null && int.TryParse(s, out h) && h >= 0 && h <= 23) return h;
            return 12;
        }

        // Đêm cuối tuần: đêm thứ Sáu và đêm thứ Bảy
        public static bool LaDemCuoiTuan(DateTime ngay)
        {
            return ngay.DayOfWeek == DayOfWeek.Friday || ngay.DayOfWeek == DayOfWeek.Saturday;
        }

        public static LoaiPhong LoaiCuaPhong(string soPhong)
        {
            Phong p = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == soPhong);
            if (p == null) return null;
            return DataStore.Loais.FirstOrDefault(l => l.Ma == p.MaLoai);
        }

        public static decimal GiaPhong(string soPhong)
        {
            LoaiPhong l = LoaiCuaPhong(soPhong);
            return l == null ? 0 : l.GiaNgay;
        }

        public static decimal GiaPhong(DatPhong d)
        {
            return GiaPhong(d.SoPhong);
        }

        // Tiền phòng của các đêm từ ngày tu đến trước ngày den, ở một phòng với giá gia
        public static DongPhong TinhDoan(string soPhong, decimal gia, DateTime tu, DateTime den)
        {
            DongPhong r = new DongPhong();
            r.SoPhong = soPhong;
            decimal he = HeSoCuoiTuan();
            for (DateTime n = tu.Date; n < den.Date; n = n.AddDays(1))
            {
                r.SoDem++;
                bool ct = LaDemCuoiTuan(n);
                if (ct) r.DemCuoiTuan++;
                r.ThanhTien += ct ? Math.Round(gia * he) : gia;
            }
            return r;
        }

        // Tiền phòng chia theo từng phòng đã ở (có tính các lần đổi phòng)
        public static List<DongPhong> ChiTietTienPhong(DatPhong d, DateTime ngayTra)
        {
            List<DongPhong> kq = new List<DongPhong>();
            DateTime tu = d.NgayDen.Date;

            foreach (DoiPhong x in DataStore.DoiPhongs.Where(z => z.MaDat == d.Ma).OrderBy(z => z.NgayDoi))
            {
                kq.Add(TinhDoan(x.PhongCu, GiaPhong(x.PhongCu), tu, x.NgayDoi));
                tu = x.NgayDoi.Date;
            }
            kq.Add(TinhDoan(d.SoPhong, GiaPhong(d.SoPhong), tu, ngayTra));

            // Tối thiểu 1 đêm cho cả đơn
            if (kq.Sum(r => r.SoDem) == 0)
                kq[kq.Count - 1] = TinhDoan(d.SoPhong, GiaPhong(d.SoPhong), tu, tu.AddDays(1));

            return kq.Where(r => r.SoDem > 0).ToList();
        }

        public static int SoDem(DatPhong d, DateTime ngayTra)
        {
            return ChiTietTienPhong(d, ngayTra).Sum(r => r.SoDem);
        }

        public static decimal TienPhong(DatPhong d, DateTime ngayTra)
        {
            return ChiTietTienPhong(d, ngayTra).Sum(r => r.ThanhTien);
        }

        public static decimal TienDichVu(string maDat)
        {
            return DataStore.SuDungs.Where(s => s.MaDat == maDat).Sum(s =>
            {
                DichVu v = DataStore.DichVus.FirstOrDefault(x => x.Ma == s.MaDV);
                return v == null ? 0m : v.Gia * s.SoLuong;
            });
        }

        public static decimal PhuThuTre(DatPhong d)
        {
            return Math.Round(GiaPhong(d.SoPhong) * HeSoPhuThu());
        }

        // Tổng tiền của đơn đã trả (dùng cho Trang chủ và Thống kê)
        public static decimal TongDaTra(DatPhong d)
        {
            return TienPhong(d, d.NgayDi) + TienDichVu(d.Ma) + d.PhuThu;
        }
    }
}