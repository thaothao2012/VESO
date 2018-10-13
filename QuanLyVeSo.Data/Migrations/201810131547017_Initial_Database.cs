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
                        TrangThai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.PhieuDangKy",
                c => new
                    {
                        MaPhieuDangKy = c.Int(nullable: false, identity: true),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        NgayDangKy = c.DateTime(nullable: false, storeType: "date"),
                        SoLuongDangKy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuDangKy)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .Index(t => t.MaDaiLy);
            
            CreateTable(
                "dbo.PhieuPhatHanh",
                c => new
                    {
                        MaPhieuPhatHanh = c.Int(nullable: false, identity: true),
                        MaDaiLy = c.String(maxLength: 15, unicode: false),
                        MaLoaiVeSo = c.String(maxLength: 15, unicode: false),
                        NgayPhatHanh = c.DateTime(nullable: false, storeType: "date"),
                        SoLuongPhatHanh = c.Int(nullable: false),
                        SoLuongBanDuoc = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaPhieuPhatHanh)
                .ForeignKey("dbo.DaiLy", t => t.MaDaiLy)
                .ForeignKey("dbo.LoaiVeSo", t => t.MaLoaiVeSo)
                .Index(t => t.MaDaiLy)
                .Index(t => t.MaLoaiVeSo);
            
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
                "dbo.GiaiThuong",
                c => new
                    {
                        MaGiaiThuong = c.String(nullable: false, maxLength: 15, unicode: false),
                        TenGiai = c.String(maxLength: 50),
                        TienThuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MaGiaiThuong);
            
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
                .ForeignKey("dbo.LoaiVeSo", t => t.MaLoaiVeSo)
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
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KetQuaXoSo", "MaLoaiVeSo", "dbo.LoaiVeSo");
            DropForeignKey("dbo.PhieuPhatHanh", "MaLoaiVeSo", "dbo.LoaiVeSo");
            DropForeignKey("dbo.CongNo", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.PhieuThu", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.PhieuPhatHanh", "MaDaiLy", "dbo.DaiLy");
            DropForeignKey("dbo.PhieuDangKy", "MaDaiLy", "dbo.DaiLy");
            DropIndex("dbo.KetQuaXoSo", new[] { "MaLoaiVeSo" });
            DropIndex("dbo.PhieuThu", new[] { "MaDaiLy" });
            DropIndex("dbo.PhieuPhatHanh", new[] { "MaLoaiVeSo" });
            DropIndex("dbo.PhieuPhatHanh", new[] { "MaDaiLy" });
            DropIndex("dbo.PhieuDangKy", new[] { "MaDaiLy" });
            DropIndex("dbo.CongNo", new[] { "MaDaiLy" });
            DropTable("dbo.LoaiVeSo");
            DropTable("dbo.KetQuaXoSo");
            DropTable("dbo.GiaVeSo");
            DropTable("dbo.GiaiThuong");
            DropTable("dbo.PhieuThu");
            DropTable("dbo.PhieuPhatHanh");
            DropTable("dbo.PhieuDangKy");
            DropTable("dbo.DaiLy");
            DropTable("dbo.CongNo");
        }
    }
}
