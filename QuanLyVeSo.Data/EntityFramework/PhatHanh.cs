using System;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhatHanh
    {
        public int ID { get; set; }

        public string MaDaiLy { get; set; }

        public string MaLoaiVeSo { get; set; }

        public int SoLuong { get; set; }

        public DateTime NgayNhan { get; set; }

        public int SoLuongBan { get; set; }

        public decimal DoanhThu { get; set; }

        public decimal HoaHong { get; set; }

        public int ConNo { get; set; }

        public DateTime NgayNop { get; set; }
    }
}