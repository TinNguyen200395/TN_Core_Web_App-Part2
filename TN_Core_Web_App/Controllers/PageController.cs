using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TN_Core_Web_App.Application.Interfaces;
namespace TN_Core_Web_App.Controllers
{
    public class PageController : Controller
    {
        private IPageService _pageService;

        public PageController(IPageService pageService)
        {
            _pageService = pageService;
        }

        [Route("page/{alias}.html", Name = "Page")]
        public IActionResult Index(string alias)
        {
            var page = _pageService.GetByAlias(alias);
            return View(page);
        }
    }
}
