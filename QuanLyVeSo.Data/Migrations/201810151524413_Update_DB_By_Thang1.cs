namespace QuanLyVeSo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update_DB_By_Thang1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GiaiThuong", "TenGiai", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.GiaiThuong", "TenGiai", c => c.String(maxLength: 50));
        }
    }
}
