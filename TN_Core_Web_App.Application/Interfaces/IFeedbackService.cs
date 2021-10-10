using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Application.ViewModels.Common;
using TN_Core_Web_App.Utilities.Dtos;

namespace TN_Core_Web_App.Application.Interfaces
{
    public interface IFeedbackService
    {
        void Add(FeedbackViewModel feedbackVm);

        void Update(FeedbackViewModel feedbackVm);

        void Delete(int id);

        List<FeedbackViewModel> GetAll();

        PagedResult<FeedbackViewModel> GetAllPaging(string keyword, int page, int pageSize);

        FeedbackViewModel GetById(int id);

        void SaveChanges();
    }
}
