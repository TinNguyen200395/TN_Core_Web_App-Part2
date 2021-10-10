﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TN_Core_Web_App.Services
{
    public interface IViewRenderService
    {
        /// <summary>
        ///     Render Razor View as String 
        /// </summary>
        /// <param name="viewName"></param>
        /// <param name="model">   </param>
        /// <returns></returns>
        Task<string> RenderToStringAsync(string viewName, object model);
    }
}
