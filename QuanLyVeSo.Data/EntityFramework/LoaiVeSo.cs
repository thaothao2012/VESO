using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class LoaiVeSo
    {
        public int ID { get; set; }

        [Index("MaLoaiVeSoIndex", IsUnique = true)]
        [Column(TypeName ="nvarchar")]
        [StringLength(20)]
        public string Ma { get; set; }

        public string TinhThanh { get; set; }

        public int Gia { get; set; }

        public DateTime NgayXo { get; set; }
    }
}