using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class KetQuaXoSo
    {
        public int ID { get; set; }

        public int LoaiVSId { get; set; }

        public DateTime NgayXo { get; set; }

        public int GiaiId { get; set; }

        public string SoTrung { get; set; }

    }
}
