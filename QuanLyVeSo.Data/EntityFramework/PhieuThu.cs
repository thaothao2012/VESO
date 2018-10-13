using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuThu
    {
        [Key]
        public int MaPhieuThu { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayThu { get; set; }

        public int TienThu { get; set; }

        public DaiLy DaiLy { get; set; }
    }
}