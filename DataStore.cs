using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

namespace WindowsFormsApp2
{
    public static class DataStore
    {
        public static List<LoaiPhong> Loais = new List<LoaiPhong>();
        public static List<Phong> Phongs = new List<Phong>();
        public static List<Khach> Khachs = new List<Khach>();
        public static List<DatPhong> Dats = new List<DatPhong>();
        public static List<DichVu> DichVus = new List<DichVu>();
        public static List<SuDungDV> SuDungs = new List<SuDungDV>();
        public static List<DoiPhong> DoiPhongs = new List<DoiPhong>();

        // Mọi form đăng ký sự kiện này để tự vẽ lại khi dữ liệu đổi
        public static event Action Changed;
        public static void RaiseChanged()
        {
            if (Changed != null) Changed();
        }

        const string FLoai = "loaiphong.txt";
        const string FPhong = "phong.txt";
        const string FKhach = "khach.txt";
        const string FDat = "datphong.txt";
        const string FDichVu = "dichvu.txt";
        const string FSuDung = "sudungdv.txt";
        const string FDoiPhong = "doiphong.txt";

        static CultureInfo Inv { get { return CultureInfo.InvariantCulture; } }
        static string D(DateTime d) { return d.ToString("yyyy-MM-dd", Inv); }
        static DateTime P(string s) { return DateTime.ParseExact(s, "yyyy-MM-dd", Inv); }

        public static void LoadAll()
        {
            // Lần chạy đầu chưa có loaiphong.txt thì tạo bộ dữ liệu mẫu
            if (!File.Exists(FileHelper.Duong(FLoai))) TaoDuLieuMau();

            Loais = FileHelper.Load(FLoai, 3, p => new LoaiPhong
            { Ma = p[0], Ten = p[1], GiaNgay = decimal.Parse(p[2], Inv) });

            Phongs = FileHelper.Load(FPhong, 4, p => new Phong
            { SoPhong = p[0], Tang = int.Parse(p[1]), MaLoai = p[2], TrangThai = p[3] });

            Khachs = FileHelper.Load(FKhach, 3, p => new Khach
            { CCCD = p[0], HoTen = p[1], SDT = p[2] });

            Dats = FileHelper.LoadRange(FDat, 6, 8, p => new DatPhong
            {
                Ma = p[0],
                CCCD = p[1],
                SoPhong = p[2],
                NgayDen = P(p[3]),
                NgayDi = P(p[4]),
                TrangThai = p[5],
                PhuThu = p.Length > 6 ? decimal.Parse(p[6], Inv) : 0,
                DaAn = p.Length > 7 && p[7] == "1"
            });

            DichVus = FileHelper.Load(FDichVu, 3, p => new DichVu
            { Ma = p[0], Ten = p[1], Gia = decimal.Parse(p[2], Inv) });

            SuDungs = FileHelper.Load(FSuDung, 4, p => new SuDungDV
            { MaDat = p[0], MaDV = p[1], SoLuong = int.Parse(p[2]), Ngay = P(p[3]) });

            DoiPhongs = FileHelper.Load(FDoiPhong, 3, p => new DoiPhong
            { MaDat = p[0], PhongCu = p[1], NgayDoi = P(p[2]) });
        }

        public static void SaveLoai()
        {
            FileHelper.Save(FLoai, Loais, l => l.Ma + ";" + l.Ten + ";" + l.GiaNgay.ToString("0", Inv));
            RaiseChanged();
        }
        public static void SavePhong()
        {
            FileHelper.Save(FPhong, Phongs, x => x.SoPhong + ";" + x.Tang + ";" + x.MaLoai + ";" + x.TrangThai);
            RaiseChanged();
        }
        public static void SaveKhach()
        {
            FileHelper.Save(FKhach, Khachs, k => k.CCCD + ";" + k.HoTen + ";" + k.SDT);
            RaiseChanged();
        }
        public static void SaveDat()
        {
            FileHelper.Save(FDat, Dats, d => d.Ma + ";" + d.CCCD + ";" + d.SoPhong + ";" +
    D(d.NgayDen) + ";" + D(d.NgayDi) + ";" + d.TrangThai + ";" +
    d.PhuThu.ToString("0", Inv) + ";" + (d.DaAn ? "1" : "0"));
            RaiseChanged();
        }
        public static void SaveDichVu()
        {
            FileHelper.Save(FDichVu, DichVus, v => v.Ma + ";" + v.Ten + ";" + v.Gia.ToString("0", Inv));
            RaiseChanged();
        }
        public static void SaveSuDung()
        {
            FileHelper.Save(FSuDung, SuDungs, s => s.MaDat + ";" + s.MaDV + ";" + s.SoLuong + ";" + D(s.Ngay));
            RaiseChanged();
        }
        public static void SaveDoiPhong()
        {
            FileHelper.Save(FDoiPhong, DoiPhongs, x => x.MaDat + ";" + x.PhongCu + ";" + D(x.NgayDoi));
            RaiseChanged();
        }

        // Dữ liệu mẫu: 3 tầng x 4 phòng, vài đặt phòng quanh ngày hôm nay
        static void TaoDuLieuMau()
        {
            DateTime h = DateTime.Today;
            Ghi(FLoai, "1;Standard;500000", "2;Deluxe;800000", "3;Suite;1500000");
            Ghi(FPhong,
                "101;1;1;CoKhach", "102;1;1;Trong", "103;1;1;Trong", "104;1;1;DangDon",
                "201;2;2;Trong", "202;2;2;CoKhach", "203;2;2;Trong", "204;2;2;Trong",
                "301;3;3;Trong", "302;3;3;Trong", "303;3;3;Trong", "304;3;3;Trong");
            Ghi(FKhach,
                "079201001234;Nguyễn Văn An;0901234567",
                "079195004567;Trần Thị Bình;0912345678",
                "075188002345;Lê Hoàng Cường;0987654321",
                "079199007890;Phạm Minh Dũng;0933221100",
                "074192003210;Võ Thu Hà;0977112233");
            Ghi(FDat,
                "D001;079201001234;101;" + D(h.AddDays(-1)) + ";" + D(h.AddDays(1)) + ";DangO",
                "D002;079195004567;202;" + D(h.AddDays(-2)) + ";" + D(h) + ";DangO",
                "D003;075188002345;301;" + D(h.AddDays(2)) + ";" + D(h.AddDays(4)) + ";DaDat",
                "D004;079199007890;103;" + D(h.AddDays(3)) + ";" + D(h.AddDays(5)) + ";DaDat",
                "D005;074192003210;204;" + D(h.AddDays(-4)) + ";" + D(h.AddDays(-1)) + ";DaTra");
            Ghi(FDichVu, "DV01;Giặt ủi;50000", "DV02;Minibar;30000", "DV03;Ăn sáng;80000", "DV04;Đưa đón sân bay;250000");
            Ghi(FSuDung,
                "D001;DV01;1;" + D(h),
                "D001;DV02;2;" + D(h),
                "D002;DV03;2;" + D(h.AddDays(-1)));
        }

        static void Ghi(string ten, params string[] dong)
        {
            File.WriteAllLines(FileHelper.Duong(ten), dong, Encoding.UTF8);
        }
    }
}