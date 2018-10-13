using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public enum TrangThai
    {
        HoatDong,
        TamDung
    }

    public class DaiLy
    {
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Key]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string TenDaiLy { get; set; }



        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        public string DiaChi { get; set; }



        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string SoDienThoai { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }


        [Required]
        public int TrangThai { get; set; }
    }
}