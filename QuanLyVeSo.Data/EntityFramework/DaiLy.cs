using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class DaiLy
    {
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Key]
        [Display(Name = "Mã đại lý")]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required(ErrorMessage ="Tên đại lý không được rỗng")]
        [Display(Name ="Tên đại lý")]
        public string TenDaiLy { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        [Required]
        [Display(Name = "Địa chỉ")]
        public string DiaChi { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Display(Name ="Số điện thoại")]
        public string SoDienThoai { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Trạng thái")]
        public bool TrangThai { get; set; }

        public ICollection<CongNo> CongNos { get; set; }

        public ICollection<PhieuDangKy> PhieuDangKys { get; set; }

        public ICollection<PhieuThu> PhieuThus { get; set; }

        public ICollection<PhieuPhatHanh> PhieuPhatHanhs { get; set; }
    }
}