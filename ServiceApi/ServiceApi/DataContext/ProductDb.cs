using Service.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceApi.DataContext
{
    public class ProductDb : DbContext
    {
        public ProductDb() : base("LeiLocal")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
