using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyVeSo.Data.EntityFramework
{
    public class GiaVeSo
    {
        [Key]
        [Required(ErrorMessage = "Mã Giá không được rỗng")]
        [Display(Name = "Mã giá")]
        public int MaGia { get; set; }

        [Required(ErrorMessage = "Giá không được rỗng")]
        [Display(Name = "Giá")]
        public int Gia { get; set; }

        [Required(ErrorMessage = "Ngày bắt đầu không được rỗng")]
        [Display(Name = "Ngày bắt đầu")]
        [Column(TypeName = "date")]
        public DateTime NgayBatDau { get; set; }


        
        [Display(Name = "Ngày kết thúc")]
        [Column(TypeName = "date")]
        public DateTime? NgayKetThuc { get; set; }

        [Required]
        public bool TrangThai { get; set; }
    }
}