using System;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class LoaiVeSo
    {
        public int ID { get; set; }
        public string Ma { get; set; }
        public string TinhThanh { get; set; }
        private int Gia { get; set; }
        public DateTime NgayXo { get; set; }
    }
}