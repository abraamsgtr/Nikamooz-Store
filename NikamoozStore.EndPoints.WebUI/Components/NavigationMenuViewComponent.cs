using System;
using Microsoft.AspNetCore.Mvc;
using NikamoozStore.Core.Contracts.Categories;
using NikamoozStore.EndPoints.WebUI.Views.Categories;

namespace NikamoozStore.EndPoints.WebUI.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly CategoryRepository _categoryRepository;

        public NavigationMenuViewComponent(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var model = new NavigationMenuViewModel
            {
                Categories = _categoryRepository.GetAll(),
            };

            if (RouteData?.Values.ContainsKey("category") == true)
            {
                model.CurrentCategory = RouteData?.Values["category"].ToString();
            }


            return View(model);
        }
    }
}
