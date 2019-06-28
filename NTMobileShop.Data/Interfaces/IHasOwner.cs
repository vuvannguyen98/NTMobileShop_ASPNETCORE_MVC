using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.Interfaces
{
    public interface IHasOwner<T>
    {
        T OwnerId { set; get; }

    }
}
