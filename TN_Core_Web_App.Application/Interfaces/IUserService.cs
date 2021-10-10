using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Application.ViewModels.System;
using TN_Core_Web_App.Utilities.Dtos;

namespace TN_Core_Web_App.Application.Interfaces
{
    public interface IUserService
    {
        Task<bool> AddAsync(AppUserViewModel userVm);

        Task DeleteAsync(string id);

        Task<List<AppUserViewModel>> GetAllAsync();

        PagedResult<AppUserViewModel> GetAllPagingAsync(string keyword, int page, int pageSize);

        Task<AppUserViewModel> GetById(string id);


        Task UpdateAsync(AppUserViewModel userVm);
    }
}
