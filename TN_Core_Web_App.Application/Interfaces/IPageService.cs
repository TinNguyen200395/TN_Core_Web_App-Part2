using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Application.ViewModels.Blog;
using TN_Core_Web_App.Utilities.Dtos;

namespace TN_Core_Web_App.Application.Interfaces
{
    public interface IPageService : IDisposable
    {
        void Add(PageViewModel pageVm);

        void Update(PageViewModel pageVm);

        void Delete(int id);

        List<PageViewModel> GetAll();

        PagedResult<PageViewModel> GetAllPaging(string keyword, int page, int pageSize);

        PageViewModel GetByAlias(string alias);

        PageViewModel GetById(int id);

        void SaveChanges();

    }
}
