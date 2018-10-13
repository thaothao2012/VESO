﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace QuanLyVeSo.Data.EntityFramework
{
    public class GiaiThuong
    {
        [Column(TypeName ="varchar")]
        [StringLength(15)]
        [Key]
        public string MaGiaiThuong { get; set; }


        [Column(TypeName = "nvarchar")]
        [StringLength(50)]
        public string TenGiai { get; set; }

        public int TienThuong { get; set; }
    }
}