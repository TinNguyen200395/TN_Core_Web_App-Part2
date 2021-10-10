using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Infrastructure.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        /// <summary>
        /// Call save change from db context
        /// </summary>
        void Commit();
    }
}
