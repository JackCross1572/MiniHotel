using System;
using System.Collections.Generic;
using System.Linq;

namespace WindowsFormsApp2
{
    public static class BookingService
    {
        // Phòng không thể đặt trong khoảng [den, di) khi:
        //  1. trùng khoảng ngày với một đơn Đã đặt hoặc Đang ở khác, hoặc
        //  2. phòng đang có khách theo trạng thái phòng (lễ tân đặt ở form Phòng)
        public static bool TrungLich(string soPhong, DateTime den, DateTime di, string boQuaMa = null)
        {
            // 1. Trùng khoảng ngày với đơn khác
            bool trungDon = DataStore.Dats.Any(d => d.SoPhong == soPhong
                && (d.TrangThai == "DaDat" || d.TrangThai == "DangO")
                && d.Ma != boQuaMa
                && den.Date < d.NgayDi.Date && d.NgayDen.Date < di.Date);
            if (trungDon) return true;

            // 2. Phòng đang có khách theo trạng thái
            Phong p = DataStore.Phongs.FirstOrDefault(x => x.SoPhong == soPhong);
            if (p != null && p.TrangThai == "CoKhach")
            {
                bool coDonDangO = DataStore.Dats.Any(d => d.SoPhong == soPhong
                    && d.TrangThai == "DangO" && d.Ma != boQuaMa);

                if (!coDonDangO) return true;                 // có khách nhưng không biết khi nào đi
                if (den.Date <= DateTime.Today) return true;  // khách vẫn đang ở (kể cả quá ngày đi)
            }
            return false;
        }

        public static List<Phong> TimPhongTrong(string maLoai, DateTime den, DateTime di)
        {
            return DataStore.Phongs
                .Where(p => p.MaLoai == maLoai && !TrungLich(p.SoPhong, den, di))
                .OrderBy(p => p.SoPhong)
                .ToList();
        }

        public static int SoDem(DatPhong d)
        {
            return Math.Max(1, (d.NgayDi.Date - d.NgayDen.Date).Days);
        }
    }
}