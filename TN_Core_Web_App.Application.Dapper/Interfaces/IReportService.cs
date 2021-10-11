using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TN_Core_Web_App.Application.Dapper.ViewModels;

namespace TN_Core_Web_App.Application.Dapper.Interfaces
{
    public interface IReportService
    {
        Task<IEnumerable<RevenueReportViewModel>> GetReportAsync(string fromDate, string toDate);
    }
}
