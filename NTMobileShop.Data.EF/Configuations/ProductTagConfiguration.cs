using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileShop.Data.EF.Extensions;
using NTMobileShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.EF.Configuations
{
    public class ProductTagConfiguration : DbEntityConfiguration<ProductTag>
    {
        public override void Configure(EntityTypeBuilder<ProductTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .HasMaxLength(50).IsUnicode(false);
            // etc.
        }
    }
}
