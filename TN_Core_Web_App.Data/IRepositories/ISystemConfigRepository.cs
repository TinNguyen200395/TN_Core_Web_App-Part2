using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Infrastructure.Interfaces;

namespace TN_Core_Web_App.Data.IRepositories
{
    public interface ISystemConfigRepository : IRepository<SystemConfig, string>
    {
    }
}
