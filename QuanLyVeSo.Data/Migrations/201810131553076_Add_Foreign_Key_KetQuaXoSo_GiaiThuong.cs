namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Foreign_Key_KetQuaXoSo_GiaiThuong : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.KetQuaXoSo", "MaGiaiThuong");
            AddForeignKey("dbo.KetQuaXoSo", "MaGiaiThuong", "dbo.GiaiThuong", "MaGiaiThuong");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.KetQuaXoSo", "MaGiaiThuong", "dbo.GiaiThuong");
            DropIndex("dbo.KetQuaXoSo", new[] { "MaGiaiThuong" });
        }
    }
}
