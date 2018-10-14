using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuDangKy
    {
        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string MaPhieuDangKy { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        public string MaDaiLy { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayDangKy { get; set; }

        public int TongSoLuongDangKy { get; set; }

        public DaiLy DaiLy { get; set; }

        public ICollection<ChiTietPhieuDangKy> ChiTietPhieuDangKys { get; set; }
    }
}