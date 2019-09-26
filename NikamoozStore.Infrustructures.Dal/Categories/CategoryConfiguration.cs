using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NikamoozStore.Core.Domain.Categories;

namespace NikamoozStore.Infrustructures.Dal.Categories
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasIndex(c => c.CategoryName).IsUnique();
            builder.Property(c => c.CategoryName).HasMaxLength(100).IsRequired();

            builder.HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Category01"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Category02"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Category03"
                });
        }
    }
}
