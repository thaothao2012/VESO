using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuThu
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(15)]
        public string MaPhieuThu { get; set; }

        public int DaiLyId { get; set; }

        public DateTime NgayThu { get; set; }

        public int TienThu { get; set; }

    }
}
