using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Application.ViewModels.Product;
using TN_Core_Web_App.Data.Enums;
using TN_Core_Web_App.Utilities.Dtos;

namespace TN_Core_Web_App.Application.Interfaces
{
    public interface IBillService
    {
        void Create(BillViewModel billVm);
        void Update(BillViewModel billVm);
        void Delete(int id);


        PagedResult<BillViewModel> GetAllPaging(string startDate, string endDate, string keyword,
            int pageIndex, int pageSize);

        BillViewModel GetDetail(int billId);

        BillDetailViewModel CreateDetail(BillDetailViewModel billDetailVm);

        void DeleteDetail(int productId, int billId, int colorId, int sizeId);

        void UpdateStatus(int orderId, BillStatus status);

        List<BillDetailViewModel> GetBillDetails(int billId);

        List<ColorViewModel> GetColors();

        List<SizeViewModel> GetSizes();

        ColorViewModel GetColor(int id);

        SizeViewModel GetSize(int id);

        void Save();
    }
}
