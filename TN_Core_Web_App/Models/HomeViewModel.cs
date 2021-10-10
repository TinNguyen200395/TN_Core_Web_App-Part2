using System.Collections.Generic;
using TN_Core_Web_App.Application.ViewModels.Blog;
using TN_Core_Web_App.Application.ViewModels.Common;
using TN_Core_Web_App.Application.ViewModels.Product;

namespace TN_Core_Web_App.Models
{
    public class HomeViewModel
    {
        public List<BlogViewModel> LastestBlogs { get; set; }
        public List<SlideViewModel> HomeSlides { get; set; }
        public List<ProductViewModel> HotProducts { get; set; }
        public List<ProductViewModel> TopSellProducts { get; set; }

        public List<ProductCategoryViewModel> HomeCategories { set; get; }

        public string Title { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
}
