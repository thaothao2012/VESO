using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class ChiTietPhieuDangKy
    {
        [Key]
        public int MaChiTietPhieuDangKy { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("PhieuDangKy")]
        public string MaPhieuDangKy { get; set; }

        public int SoLuongDangKy { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("LoaiVeSo")]
        public string MaLoaiVeSo { get; set; }

        public PhieuDangKy PhieuDangKy { get; set; }

        public LoaiVeSo LoaiVeSo { get; set; }
    }
}