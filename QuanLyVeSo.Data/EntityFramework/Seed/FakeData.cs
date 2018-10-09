using System;
using System.Collections.Generic;

namespace QuanLyVeSo.Data.EntityFramework.Seed
{
    public class FakeData
    {
        public List<LoaiVeSo> SeedLoaiVeSo()
        {
            var list = new List<LoaiVeSo>{
                new LoaiVeSo(){Ma="1",TinhThanh="1",Gia=18, NgayXo=DateTime.Now},
            };

            return list;
        }
    }
}