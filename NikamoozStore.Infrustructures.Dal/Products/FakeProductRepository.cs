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

        public List<Product> GetProducts()
        {
            return _ctx.Products.Include(c => c.Category).ToList();
        }
    }

    public class FakeProductRepository : ProductRepository
    {
        private List<Product> _products = new List<Product>
        {
            
        };
        public List<Product> GetProducts()
        {
            return _products;
        }
    }
}
