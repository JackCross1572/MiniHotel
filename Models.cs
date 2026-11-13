namespace WindowsFormsApp2
{
    public class DoiPhong
    {
        public string MaDat { get; set; }
        public string PhongCu { get; set; }
        public System.DateTime NgayDoi { get; set; }   // ngày rời phòng cũ
    }
    public class LoaiPhong
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public decimal GiaNgay { get; set; }
    }

    public class Phong
    {
        public string SoPhong { get; set; }
        public int Tang { get; set; }
        public string MaLoai { get; set; }
        public string TrangThai { get; set; }   // Trong, CoKhach, DangDon
    }

    public class Khach
    {
        public string CCCD { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
    }

    public class DatPhong
    {
        public string Ma { get; set; }
        public string CCCD { get; set; }
        public string SoPhong { get; set; }
        public System.DateTime NgayDen { get; set; }
        public System.DateTime NgayDi { get; set; }
        public string TrangThai { get; set; }   // DaDat, DangO, DaTra, Huy
        public decimal PhuThu { get; set; }     // phụ thu trả trễ, ghi khi trả phòng
        public bool DaAn { get; set; }          // true = đã xóa khỏi danh sách (vẫn lưu để thống kê)
    }

    public class DichVu
    {
        public string Ma { get; set; }
        public string Ten { get; set; }
        public decimal Gia { get; set; }
        public decimal PhuThu { get; set; }     // phụ thu trả trễ, ghi khi trả phòng
    }

    public class SuDungDV
    {
        public string MaDat { get; set; }
        public string MaDV { get; set; }
        public int SoLuong { get; set; }
        public System.DateTime Ngay { get; set; }
    }
}