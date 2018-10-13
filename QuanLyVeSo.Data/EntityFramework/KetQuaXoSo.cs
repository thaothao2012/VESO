using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class KetQuaXoSo
    {
        [Key]
        public int MaKetQuaXoSo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("LoaiVeSo")]
        public string MaLoaiVeSo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("GiaiThuong")]
        public string MaGiaiThuong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayXo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(7)]
        public string SoTrung { get; set; }

        public LoaiVeSo LoaiVeSo { get; set; }

        public GiaiThuong GiaiThuong { get; set; }
    }
}