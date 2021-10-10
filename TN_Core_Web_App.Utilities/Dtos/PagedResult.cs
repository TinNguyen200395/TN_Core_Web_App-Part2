using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Utilities.Dtos
{
    public class PagedResult<T> : PagedResultBase where T:class
    {
        public PagedResult()
        {
            Results = new List<T>();
        }
        public IList<T> Results { get; set; }
    }
}
