using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyVeSo.Data.EntityFramework
{
    public class GiaiThuong
    {
        [Column(TypeName ="varchar")]
        [StringLength(15)]
        [Key]
        [Required(ErrorMessage = "Mã giải thưởng không được trống")]
        [Display(Name = "Mã giải thưởng")]

        public string MaGiaiThuong { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        [Required(ErrorMessage = "Tên giải không được trống")]
        [Display(Name = "Tên giải")]
        public string TenGiai { get; set; }


        [Required(ErrorMessage = "Tiền thưởng không được trống")]
        [Display(Name = "Tiền thưởng")]

        public int TienThuong { get; set; }
    }
}
