using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Data.Entities;
using TN_Core_Web_App.Data.IRepositories;

namespace TN_Core_Web_App.Data.EF.Repositories
{
    public class BlogTagRepository : EFRepository<BlogTag, int>, IBlogTagRepository
    {
        public BlogTagRepository(AppDbContext context) : base(context)
        {
        }
    }
}
