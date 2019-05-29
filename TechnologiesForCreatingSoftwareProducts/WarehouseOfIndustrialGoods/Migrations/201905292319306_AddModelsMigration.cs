namespace WarehouseOfIndustrialGoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddModelsMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Consumers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Supplies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AlterColumn("dbo.Products", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplies", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Supplies", new[] { "EmployeeId" });
            AlterColumn("dbo.Products", "Name", c => c.String());
            DropTable("dbo.Suppliers");
            DropTable("dbo.Supplies");
            DropTable("dbo.Employees");
            DropTable("dbo.Consumers");
        }
    }
}
