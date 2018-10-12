using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class CongNo
    {
        public int ID { get; set; }

        public int DaiLyId { get; set; }

        public int SoTienBan { get; set; }

        public float HoaHong { get; set; }

        public DateTime NgayNo { get; set; }

        public int SoTienNo { get; set; }


    }
}
