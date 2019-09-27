using System;
using System.Collections.Generic;
using NikamoozStore.Core.Domain.Categories;

namespace NikamoozStore.EndPoints.WebUI.Views.Categories
{
    public class NavigationMenuViewModel
    {
        public List<Category> Categories { get; set; }
        public string CurrentCategory { get; set; }

    }
}
