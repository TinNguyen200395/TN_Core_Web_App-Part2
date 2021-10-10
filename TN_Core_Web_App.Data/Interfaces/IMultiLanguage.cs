using System;
using System.Collections.Generic;
using System.Text;

namespace TN_Core_Web_App.Data.Interfaces
{
    public interface IMultiLanguage<T>
    {
        T LanguageId { set; get; }
    }
}
