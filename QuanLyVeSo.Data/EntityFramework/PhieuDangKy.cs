using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuDangKy
    {
        [Key]
        public int MaPhieuDangKy { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        public string MaDaiLy { get; set; }

        
        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        public int SoLuongDangKy { get; set; }

        public DaiLy DaiLy { get; set; }
    }
}
