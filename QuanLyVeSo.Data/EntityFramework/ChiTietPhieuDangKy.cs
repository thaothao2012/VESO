﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyVeSo.Data.EntityFramework
{
    public class ChiTietPhieuDangKy
    {
        [Key]
        public int MaChiTietPhieuDangKy { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        [ForeignKey("PhieuDangKy")]
        public string MaPhieuDangKy { get; set; }


        [Column(TypeName = "varchar")]
        [StringLength(15)]
        public string MaLoaiVeSo { get; set; }


        public int SoLuongDangKy { get; set; }
        public PhieuDangKy PhieuDangKy { get; set; }
    }
}
