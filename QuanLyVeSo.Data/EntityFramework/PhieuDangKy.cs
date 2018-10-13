using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuDangKy
    {
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Key]
        public string MaPhieuDangKy { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaDaiLy { get; set; }

        
        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        public int TongSoLuongDangKy { get; set; }


    }
}
