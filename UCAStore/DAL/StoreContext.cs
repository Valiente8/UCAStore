using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UCAStore.Models;
using System.Data.Entity;

namespace UCAStore.DAL
{
    public class StoreContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Image> Images { get; set; }
    }
}