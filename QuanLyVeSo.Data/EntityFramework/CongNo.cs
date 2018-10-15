using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class CongNo
    {
        [Key]        
        [Display(Name = "Mã công nợ")]
        [Required(ErrorMessage = "Mã công nợ không được rỗng")]
        public int MaCongNo { get; set; }
        

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        [Display(Name = "Mã đại lý")]
        public string MaDaiLy { get; set; }

        [Required(ErrorMessage = "Số tiền bán không được rỗng")]
        [Display(Name = "Số tiền bán")]
        public int SoTienBan { get; set; }


        [Required(ErrorMessage = "Hoa hồng không được rỗng")]
        [Display(Name = "Hoa hồng")]
        public float HoaHong { get; set; }

        [Required(ErrorMessage = "Ngày nợ không được rỗng")]
        [Display(Name = "Ngày nợ")]
        [Column(TypeName = "date")]
        public DateTime NgayNo { get; set; }

        [Required(ErrorMessage = "Số tiền nợ không được rỗng")]
        [Display(Name = "Số tiền nợ")]
        public int SoTienNo { get; set; }

        public DaiLy DaiLy { get; set; }

        public CongNo()
        {
            this.HoaHong = 0.1F;
        }
    }
}