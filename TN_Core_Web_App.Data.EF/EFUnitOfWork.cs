using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Infrastructure.Interfaces;

namespace TN_Core_Web_App.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        /// <summary>
        /// khi new moi cần tạo một constructor
        /// </summary>
        /// <param name="context"></param>
        public EFUnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
