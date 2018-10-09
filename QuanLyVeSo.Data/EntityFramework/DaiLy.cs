namespace QuanLyVeSo.Data.EntityFramework
{
    public enum TrangThai : int
    {
        HoatDong,
        TamDung
    }

    public class DaiLy
    {

        public int ID { get; set; }

        public string Ma { get; set; }

        public string Ten { get; set; }

        public string DiaChi { get; set; }

        public string Email { get; set; }

        public TrangThai DangHoatDong { get; set; }
    }
}