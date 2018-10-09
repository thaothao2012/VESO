using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public enum TrangThai
    {
        HoatDong,
        TamDung
    }

    public class DaiLy
    {
        public int ID { get; set; }

        [Index("MaDaiLyIndex", IsUnique = true)]
        [Column(TypeName = "nvarchar")]
        [StringLength(20)]
        public string Ma { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public TrangThai TrangThai { get; set; }
    }
}