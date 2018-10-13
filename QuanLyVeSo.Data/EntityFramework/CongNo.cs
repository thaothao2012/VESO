using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class CongNo
    {
        [Key]
        public int MaCongNo { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("DaiLy")]
        public string MaDaiLy { get; set; }

        public int SoTienBan { get; set; }

        public float HoaHong { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayNo { get; set; }

        public int SoTienNo { get; set; }

        public DaiLy DaiLy { get; set; }

        public CongNo()
        {
            this.HoaHong = 0.1F;
        }
    }
}