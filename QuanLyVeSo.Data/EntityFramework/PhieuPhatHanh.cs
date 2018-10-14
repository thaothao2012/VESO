using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuPhatHanh
    {
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Key]
        public string MaPhieuPhatHanh { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "date")]
        [Required]
        public DateTime NgayPhatHanh { get; set; }

        [Required]
        public int TongSoLuongPhat { get; set; }

        public DaiLy DaiLy { get; set; }

        public ICollection<ChiTietPhieuPhatHanh> ChiTietPhieuPhatHanhs { get; set; }
    }
}