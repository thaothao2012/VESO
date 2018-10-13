using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class LoaiVeSo
    {
        [Column(TypeName ="varchar")]
        [StringLength(15)]
        [Key]
        public string MaLoaiVeSo { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required]
        public string TenTinhThanh { get; set; }

        public int Gia { get; set; }

        public DateTime NgayXo { get; set; }
    }
}