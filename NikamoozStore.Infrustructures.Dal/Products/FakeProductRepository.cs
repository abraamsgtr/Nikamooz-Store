using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;
using NikamoozStore.Core.Contracts.Productss;
using NikamoozStore.Core.Domain.Products;
using NikamoozStore.Infrustructures.Dal.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace NikamoozStore.Infrustructures.Dal.Products
{

    public class EfProductRepository : ProductRepository
    {
        private readonly NikamoozStoreContext _ctx;

        public EfProductRepository(NikamoozStoreContext ctx)
        {
            _ctx = ctx;
        }

        public List<Product> GetProducts(string category, int pageSize = 4, int pageNumber = 1)
        {
            return _ctx.Products.Where(c => string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category).Include(c => c.Category).Skip(pageSize * (pageNumber -1)).Take(pageSize).ToList();
        }

        public int TotalCount(string category)
        {
            return _ctx.Products.Count(c=>string.IsNullOrWhiteSpace(category) || c.Category.CategoryName == category);
        }
    }

    //public class FakeProductRepository : ProductRepository
    //{
    //    private List<Product> _products = new List<Product>
    //    {
            
    //    };
    //    public List<Product> GetProducts()
    //    {
    //        return _products;
    //    }

    //    public List<Product> GetProducts(int pageSize = 4, int pageNumber = 1)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
