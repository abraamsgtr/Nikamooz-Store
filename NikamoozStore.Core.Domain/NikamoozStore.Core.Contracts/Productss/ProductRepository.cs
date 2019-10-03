using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;
using NikamoozStore.Core.Domain.Products;

namespace NikamoozStore.Core.Contracts.Productss
{
    public interface ProductRepository
    {
        int TotalCount(string category);
        //number of items in page is pageSize and which page is pageIndex
        public List<Product> GetProducts(string category, int pageSize = 4, int pageNumber = 1);
    }
}
