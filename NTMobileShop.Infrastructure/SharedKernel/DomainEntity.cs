using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Infrastructure.SharedKernel
{
    public class DomainEntity<T>
    {
        public T Id { get; set; }

        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}
