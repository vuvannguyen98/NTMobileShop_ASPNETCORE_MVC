using NTMobileShop.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.Interfaces
{
    public interface ISwitchable
    {
        Status Status { set; get; }
    }
}
