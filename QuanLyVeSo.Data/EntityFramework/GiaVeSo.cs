using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class GiaVeSo
    {
        [Key]
        public int MaGia { get; set; }

        public int Gia { get; set; }

        [Column(TypeName ="date")]
        public DateTime NgayBatDau { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKetThuc { get; set; }

        public int TrangThai { get; set; }


    }
}
