using Microsoft.EntityFrameworkCore;
using Store.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Store.Infrastructure
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
