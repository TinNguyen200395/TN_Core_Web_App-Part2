using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TN_Core_Web_App.Application.Interfaces;

namespace TN_Core_Web_App.Controllers.Components
{
    public class MainMenuViewComponent : ViewComponent
    {

        private IProductCategoryService _productCategoryService;

        public MainMenuViewComponent(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(_productCategoryService.GetAll());
        }
    }
}
