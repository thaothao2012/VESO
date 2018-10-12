using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuPhatHanh
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string MaLoaiVeSo { get; set; }

        public int SoLuong { get; set; }

        public DateTime NgayNhan { get; set; }

        public int SoLuongBan { get; set; }

        public decimal DoanhThu { get; set; }

        public decimal HoaHong { get; set; }

        public decimal ConNo { get; set; }

        public DateTime NgayNop { get; set; }
    }
}