using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TN_Core_Web_App.Extensions;

namespace TN_Core_Web_App.Areas.Admin.Controllers
{
 
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            var email = User.GetSpecificClaim("Email");

            return View();
        }
    }
}