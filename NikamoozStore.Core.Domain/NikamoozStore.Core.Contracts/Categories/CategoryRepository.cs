using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;

namespace NikamoozStore.Core.Contracts.Categories
{
    public interface CategoryRepository
    {
        List<Category> GetAll();
    }
}
