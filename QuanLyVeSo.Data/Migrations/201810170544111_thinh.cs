namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thinh : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiaVeSo", "NgayKetThuc", c => c.DateTime(storeType: "date"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiaVeSo", "NgayKetThuc", c => c.DateTime(nullable: false, storeType: "date"));
        }
    }
}
