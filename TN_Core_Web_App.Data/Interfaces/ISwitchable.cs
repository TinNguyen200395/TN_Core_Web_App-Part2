using System;
using System.Collections.Generic;
using System.Text;
using TN_Core_Web_App.Data.Enums;

namespace TN_Core_Web_App.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
