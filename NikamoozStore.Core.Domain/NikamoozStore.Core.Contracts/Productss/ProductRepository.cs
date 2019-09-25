using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;
using NikamoozStore.Core.Domain.Products;

namespace NikamoozStore.Core.Contracts.Productss
{
    public interface ProductRepository
    {
        public List<Product> GetProducts();
    }
}
