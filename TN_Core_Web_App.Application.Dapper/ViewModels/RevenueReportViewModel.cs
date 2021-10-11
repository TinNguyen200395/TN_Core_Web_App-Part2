using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Application.Dapper.ViewModels
{
    public class RevenueReportViewModel
    {
        public DateTime Date { get; set; }
        public decimal Revenue { get; set; }

        public decimal Profit { get; set; }
    }
}
