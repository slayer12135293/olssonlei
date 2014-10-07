namespace ServiceApi.DataContext.ProductMigrations
{
    using Service.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ServiceApi.DataContext.ProductDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"DataContext\ProductMigrations";
        }

        protected override void Seed(ServiceApi.DataContext.ProductDb context)
        {
            context.Products.AddOrUpdate(x => x.Name, 
                new Product() { Name = "Sakura", ProductCode = "sk0001" }, 
                new Product() { Name = "Cammy", ProductCode = "ca0031" }, 
                new Product { Name = "Chun Li", ProductCode = "cl022145", Catagory = new ProductCatagory { Id = 1, Name = "CatagoryA" }, Type = new ProductType {Id=1, Name="TypeA" } });
         
        }
    }
}
