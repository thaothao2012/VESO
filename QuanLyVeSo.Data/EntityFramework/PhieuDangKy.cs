using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class PhieuDangKy
    {
        public int ID { get; set; }

        [Column(TypeName = "nvarchar")]
        [StringLength(15)]
        public string MaPhieuDK { get; set; }

        public int DaiLyId { get; set; }

        public DateTime NgayDK { get; set; }

        public int SoLuongDK { get; set; }


    }
}
