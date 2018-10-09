namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Datbase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DaiLy",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ma = c.String(maxLength: 20),
                        Ten = c.String(),
                        DiaChi = c.String(),
                        Email = c.String(),
                        TrangThai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Ma, unique: true, name: "MaDaiLyIndex");
            
            CreateTable(
                "dbo.LoaiVeSo",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ma = c.String(maxLength: 20),
                        TinhThanh = c.String(),
                        Gia = c.Int(nullable: false),
                        NgayXo = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .Index(t => t.Ma, unique: true, name: "MaLoaiVeSoIndex");
            
            CreateTable(
                "dbo.PhatHanh",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MaDaiLy = c.String(),
                        MaLoaiVeSo = c.String(),
                        SoLuong = c.Int(nullable: false),
                        NgayNhan = c.DateTime(nullable: false),
                        SoLuongBan = c.Int(nullable: false),
                        DoanhThu = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HoaHong = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ConNo = c.Decimal(nullable: false, precision: 18, scale: 2),
                        NgayNop = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.LoaiVeSo", "MaLoaiVeSoIndex");
            DropIndex("dbo.DaiLy", "MaDaiLyIndex");
            DropTable("dbo.PhatHanh");
            DropTable("dbo.LoaiVeSo");
            DropTable("dbo.DaiLy");
        }
    }
}
