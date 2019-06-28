using AutoMapper;
using NTMobileShop.Application.ViewModels.Product;
using NTMobileShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<ProductCategory, ProductCategoryViewModel>();
        }
    }
}
