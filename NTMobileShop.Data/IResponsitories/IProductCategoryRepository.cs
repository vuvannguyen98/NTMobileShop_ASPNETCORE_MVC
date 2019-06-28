using NTMobileShop.Data.Entities;
using NTMobileShop.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.IResponsitories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory,int>
    {
        List<ProductCategory> GetByAlias(string alias);
    }
}
