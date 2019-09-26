using System;
using Microsoft.EntityFrameworkCore;
using NikamoozStore.Core.Domain.Categories;
using NikamoozStore.Core.Domain.Products;
using System.Collections.Generic;
using NikamoozStore.Infrustructures.Dal.Products;
using NikamoozStore.Infrustructures.Dal.Categories;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace NikamoozStore.Infrustructures.Dal.Common
{
    public class NikamoozStoreContext:DbContext
    {
        public NikamoozStoreContext(DbContextOptions<NikamoozStoreContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }


        //DbContextOptionsBuilder.EnableSensitiveDataLogging<options => options.EnableSensitiveDataLogging>

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            //modelBuilder.Entity<Product>().OwnsOne(c => c.Category).HasData

            //DbContextOptionsBuilder(options => options.EnableSensitiveDataLogging);

            base.OnModelCreating(modelBuilder);
        }
    }
}
