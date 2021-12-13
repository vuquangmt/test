namespace test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Create_Table_NhanVien : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        NhanVienID = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        SDT = c.String(),
                        Tuoi = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.NhanVienID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.NhanViens");
        }
    }
}
