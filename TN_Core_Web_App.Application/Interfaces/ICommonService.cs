using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Application.ViewModels.Common;

namespace TN_Core_Web_App.Application.Interfaces
{
    public interface ICommonService
    {
        FooterViewModel GetFooter();
        List<SlideViewModel> GetSlides(string groupAlias);
        SystemConfigViewModel GetSystemConfig(string code);
    }
}
