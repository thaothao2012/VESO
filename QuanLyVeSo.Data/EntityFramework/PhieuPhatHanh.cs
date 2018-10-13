using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuPhatHanh
    {
        [Key]
        public int MaPhieuPhatHanh { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaDaiLy { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaLoaiVeSo { get; set; }


        [Column(TypeName = "date")]
        [Required]
        public DateTime NgayPhatHanh { get; set; }

        [Required]
        public int SoLuongPhatHanh { get; set; }


        public int SoLuongBanDuoc { get; set; }
    }
}