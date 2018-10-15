namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DB_By_Thang : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiaVeSo", "TrangThai", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiaVeSo", "TrangThai", c => c.Int(nullable: false));
        }
    }
}
