using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Data.IRepositories;

namespace TN_Core_Web_App.Data.EF.Repositories
{
    public class ProductQuantityRepository : EFRepository<ProductQuantity, int>, IProductQuantityRepository
    {
        public ProductQuantityRepository(AppDbContext context) : base(context)
        {
        }
    }
}
