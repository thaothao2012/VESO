using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    class ChiTietPhieuPhatHanh
    {
        [Key]
        public int MaChiTietPhieuPhatHanh { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaPhieuPhatHanh { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaLoaiVeSo { get; set; }

        [Required]
        public int SoLuongPhatHanh { get; set; }
    }
}
