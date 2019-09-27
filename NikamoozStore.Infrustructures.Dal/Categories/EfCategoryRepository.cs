using System;
using NikamoozStore.Core.Contracts.Categories;
using NikamoozStore.Infrustructures.Dal.Common;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;
using System.Linq;

namespace NikamoozStore.Infrustructures.Dal.Categories
{
    public class EfCategoryRepository : CategoryRepository
    {
        private readonly NikamoozStoreContext _ctx;

        public EfCategoryRepository(NikamoozStoreContext ctx)
        {
            _ctx = ctx;
        }

        public List<Category> GetAll()
        {
            return _ctx.Categories.ToList();
        }
    }
}
