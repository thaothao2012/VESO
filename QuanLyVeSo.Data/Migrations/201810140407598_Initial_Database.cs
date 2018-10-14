namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Database : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CongNo",
                c => new
                    {
                        MaCongNo = c.Int(nullable: false, identity: true),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        SoTienBan = c.Int(nullable: false),
                        HoaHong = c.Single(nullable: false),
                        NgayNo = c.DateTime(nullable: false, storeType: "date"),
                        SoTienNo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaCongNo)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .Index(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.DaiLy",
                c => new
                    {
                        MaDaiLy = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenDaiLy = c.String(nullable: false, maxLength: 100),
                        DiaChi = c.String(nullable: false, maxLength: 100),
                        SoDienThoai = c.String(maxLength: 15, unicode: false),
                        Email = c.String(nullable: false, maxLength: 50, unicode: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.PhieuDangKy",
                c => new
                    {
                        MaPhieuDangKy = c.String(nullable: false, maxLength: 15, unicode: false),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        NgayDangKy = c.DateTime(nullable: false, storeType: "date"),
                        TongSoLuongDangKy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuDangKy)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .Index(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.ChiTietPhieuDangKy",
                c => new
                    {
                        MaChiTietPhieuDangKy = c.Int(nullable: false, identity: true),
                        MaPhieuDangKy = c.String(maxLength: 15, unicode: false),
                        SoLuongDangKy = c.Int(nullable: false),
                        MaLoaiVeSo = c.String(maxLength: 15, unicode: false),
                    })
                .PrimaryKey(t => t.MaChiTietPhieuDangKy)
                .ForeignKey("dbo.LoaiVeSo", t => t.MaLoaiVeSo)
                .ForeignKey("dbo.PhieuDangKy", t => t.MaPhieuDangKy)
                .Index(t => t.MaPhieuDangKy)
                .Index(t => t.MaLoaiVeSo);
            
            CreateTable(
                "dbo.LoaiVeSo",
                c => new
                    {
                        MaLoaiVeSo = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenTinhThanh = c.String(nullable: false, maxLength: 50),
                        Gia = c.Int(nullable: false),
                        NgayXo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.MaLoaiVeSo);
            
            CreateTable(
                "dbo.ChiTietPhieuPhatHanh",
                c => new
                    {
                        MaChiTietPhieuPhatHanh = c.Int(nullable: false, identity: true),
                        MaPhieuPhatHanh = c.String(maxLength: 15, unicode: false),
                        MaLoaiVeSo = c.String(maxLength: 15, unicode: false),
                        SoLuongPhatHanh = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaChiTietPhieuPhatHanh)
                .ForeignKey("dbo.LoaiVeSo", t => t.MaLoaiVeSo)
                .ForeignKey("dbo.PhieuPhatHanh", t => t.MaPhieuPhatHanh)
                .Index(t => t.MaPhieuPhatHanh)
                .Index(t => t.MaLoaiVeSo);
            
            CreateTable(
                "dbo.PhieuPhatHanh",
                c => new
                    {
                        MaPhieuPhatHanh = c.String(nullable: false, maxLength: 15, unicode: false),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        NgayPhatHanh = c.DateTime(nullable: false, storeType: "date"),
                        TongSoLuongPhat = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuPhatHanh)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .Index(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.KetQuaXoSo",
                c => new
                    {
                        MaKetQuaXoSo = c.Int(nullable: false, identity: true),
                        MaLoaiVeSo = c.String(maxLength: 15, unicode: false),
                        MaGiaiThuong = c.String(maxLength: 15, unicode: false),
                        NgayXo = c.DateTime(nullable: false, storeType: "date"),
                        SoTrung = c.String(maxLength: 7, unicode: false),
                    })
                .PrimaryKey(t => t.MaKetQuaXoSo)
                .ForeignKey("dbo.GiaiThuong", t => t.MaGiaiThuong)
                .ForeignKey("dbo.LoaiVeSo", t => t.MaLoaiVeSo)
                .Index(t => t.MaLoaiVeSo)
                .Index(t => t.MaGiaiThuong);
            
            CreateTable(
                "dbo.GiaiThuong",
                c => new
                    {
                        MaGiaiThuong = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenGiai = c.String(maxLength: 50),
                        TienThuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGiaiThuong);
            
            CreateTable(
                "dbo.PhieuThu",
                c => new
                    {
                        MaPhieuThu = c.Int(nullable: false, identity: true),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        NgayThu = c.DateTime(nullable: false, storeType: "date"),
                        TienThu = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuThu)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .Index(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.GiaVeSo",
                c => new
                    {
                        MaGia = c.Int(nullable: false, identity: true),
                        Gia = c.Int(nullable: false),
                        NgayBatDau = c.DateTime(nullable: false, storeType: "date"),
                        NgayKetThuc = c.DateTime(nullable: false, storeType: "date"),
                        TrangThai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGia);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CongNo", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.PhieuThu", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.PhieuDangKy", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.ChiTietPhieuDangKy", "MaPhieuDangKy", "dbo.PhieuDangKy");
            DropForeignKey("dbo.ChiTietPhieuDangKy", "MaLoaiVeSo", "dbo.LoaiVeSo");
            DropForeignKey("dbo.KetQuaXoSo", "MaLoaiVeSo", "dbo.LoaiVeSo");
            DropForeignKey("dbo.KetQuaXoSo", "MaGiaiThuong", "dbo.GiaiThuong");
            DropForeignKey("dbo.ChiTietPhieuPhatHanh", "MaPhieuPhatHanh", "dbo.PhieuPhatHanh");
            DropForeignKey("dbo.PhieuPhatHanh", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.ChiTietPhieuPhatHanh", "MaLoaiVeSo", "dbo.LoaiVeSo");
            DropIndex("dbo.PhieuThu", new[] { "MaDaiLy" });
            DropIndex("dbo.KetQuaXoSo", new[] { "MaGiaiThuong" });
            DropIndex("dbo.KetQuaXoSo", new[] { "MaLoaiVeSo" });
            DropIndex("dbo.PhieuPhatHanh", new[] { "MaDaiLy" });
            DropIndex("dbo.ChiTietPhieuPhatHanh", new[] { "MaLoaiVeSo" });
            DropIndex("dbo.ChiTietPhieuPhatHanh", new[] { "MaPhieuPhatHanh" });
            DropIndex("dbo.ChiTietPhieuDangKy", new[] { "MaLoaiVeSo" });
            DropIndex("dbo.ChiTietPhieuDangKy", new[] { "MaPhieuDangKy" });
            DropIndex("dbo.PhieuDangKy", new[] { "MaDaiLy" });
            DropIndex("dbo.CongNo", new[] { "MaDaiLy" });
            DropTable("dbo.GiaVeSo");
            DropTable("dbo.PhieuThu");
            DropTable("dbo.GiaiThuong");
            DropTable("dbo.KetQuaXoSo");
            DropTable("dbo.PhieuPhatHanh");
            DropTable("dbo.ChiTietPhieuPhatHanh");
            DropTable("dbo.LoaiVeSo");
            DropTable("dbo.ChiTietPhieuDangKy");
            DropTable("dbo.PhieuDangKy");
            DropTable("dbo.DaiLy");
            DropTable("dbo.CongNo");
        }
    }
}
