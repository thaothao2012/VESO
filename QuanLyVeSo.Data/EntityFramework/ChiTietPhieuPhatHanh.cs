using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class ChiTietPhieuPhatHanh
    {
        [Key]
        public int MaChiTietPhieuPhatHanh { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("PhieuPhatHanh")]
        public string MaPhieuPhatHanh { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("LoaiVeSo")]
        public string MaLoaiVeSo { get; set; }

        [Required]
        public int SoLuongPhatHanh { get; set; }

        public PhieuPhatHanh PhieuPhatHanh { get; set; }

        public LoaiVeSo LoaiVeSo { get; set; }
    }
}