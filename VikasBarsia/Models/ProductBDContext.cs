using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace VikasBarsia.Models
{
    public class ProductBDContext:DbContext
    {
        public ProductBDContext():base("DBCS")
        {

        }
        public DbSet<Product> Products { get; set; } //All Crud Operation.
        public DbSet<Category> Categories { get; set; }
    }
}