using System;
using NikamoozStore.Core.Domain.Categories;

namespace NikamoozStore.Core.Domain.Products
{
    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        
        public Category Category { get; set; }
        public int CategoryId { get; set; }
    }
}
