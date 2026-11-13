using System;

namespace WindowsFormsApp2
{
    // Số liệu của một kỳ (một tháng hoặc một tuần)
    public class KyThongKe
    {
        public string Nhan;        // nhãn trục X
        public string MoTa;        // dùng trong thẻ và báo cáo
        public DateTime Tu;        // từ ngày (gồm)
        public DateTime Den;       // đến ngày (không gồm)
        public decimal DoanhThu;
        public int Luot;           // số lượt trả phòng
        public int DemBan;         // số đêm đã ở
        public decimal CongSuat;   // phần trăm
    }
}