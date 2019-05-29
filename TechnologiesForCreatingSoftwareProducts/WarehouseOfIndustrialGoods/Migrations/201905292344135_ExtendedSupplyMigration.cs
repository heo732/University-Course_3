namespace WarehouseOfIndustrialGoods.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ExtendedSupplyMigration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Supplies", "SupplierId", c => c.Int(nullable: false));
            AddColumn("dbo.Supplies", "ProductId", c => c.Int(nullable: false));
            AddColumn("dbo.Supplies", "CountOfProduct", c => c.Int(nullable: false));
            AddColumn("dbo.Supplies", "DateTime", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Supplies", "SupplierId");
            CreateIndex("dbo.Supplies", "ProductId");
            AddForeignKey("dbo.Supplies", "ProductId", "dbo.Products", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Supplies", "SupplierId", "dbo.Suppliers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Supplies", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Supplies", "ProductId", "dbo.Products");
            DropIndex("dbo.Supplies", new[] { "ProductId" });
            DropIndex("dbo.Supplies", new[] { "SupplierId" });
            DropColumn("dbo.Supplies", "DateTime");
            DropColumn("dbo.Supplies", "CountOfProduct");
            DropColumn("dbo.Supplies", "ProductId");
            DropColumn("dbo.Supplies", "SupplierId");
        }
    }
}
