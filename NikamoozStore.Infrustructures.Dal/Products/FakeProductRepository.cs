using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;
using NikamoozStore.Core.Contracts.Productss;
using NikamoozStore.Core.Domain.Products;

namespace NikamoozStore.Infrustructures.Dal.Products
{
    public class FakeProductRepository : ProductRepository
    {
        private List<Product> _products = new List<Product>
        {
            new Product
            {
                Category = new Category
                {
                    CategoryId = 1,
                    CategoryName = "Category01"
                },
                Description = "Description Product 01",
                Name = "Product01",
                Price = 100,
                ProductID = 1,
                Image = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITERUSEBIVFRUXFRUWFRIVFRUVFx",
            },
            new Product
            {
                Category = new Category
                {
                    CategoryId = 1,
                    CategoryName = "Category01"
                },
                Description = "Description Product 02",
                Name = "Product02",
                Price = 120,
                ProductID = 2,
                Image = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITERUSEBIVFRUXFRUWFRIVFRUVFx",
            },
            new Product
            {
                Category = new Category
                {
                    CategoryId = 3,
                    CategoryName = "Category03"
                },
                Description = "Description Product 03",
                Name = "Product03",
                Price = 140,
                ProductID = 3,
                Image = "data:image/jpeg;base64,/9j/4AAQSkZJRgABAQAAAQABAAD/2wCEAAkGBxITERUSEBIVFRUXFRUWFRIVFRUVFx",
            },
        };
        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
