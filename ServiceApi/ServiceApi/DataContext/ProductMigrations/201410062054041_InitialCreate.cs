namespace ServiceApi.DataContext.ProductMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductCode = c.String(nullable: false),
                        Width = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Height = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ImageUrl = c.String(),
                        CurrentDiscount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        IsNewProduct = c.Boolean(nullable: false),
                        ColorName = c.String(),
                        ColoCode = c.String(),
                        Name = c.String(nullable: false),
                        Catagory_Id = c.Int(),
                        Type_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ProductCatagories", t => t.Catagory_Id)
                .ForeignKey("dbo.ProductTypes", t => t.Type_Id)
                .Index(t => t.Catagory_Id)
                .Index(t => t.Type_Id);
            
            CreateTable(
                "dbo.ProductCatagories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProductTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Type_Id", "dbo.ProductTypes");
            DropForeignKey("dbo.Products", "Catagory_Id", "dbo.ProductCatagories");
            DropIndex("dbo.Products", new[] { "Type_Id" });
            DropIndex("dbo.Products", new[] { "Catagory_Id" });
            DropTable("dbo.ProductTypes");
            DropTable("dbo.ProductCatagories");
            DropTable("dbo.Products");
        }
    }
}
