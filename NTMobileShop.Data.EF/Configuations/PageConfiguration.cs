using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileShop.Data.EF.Extensions;
using NTMobileShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.EF.Configuations
{
    public class PageConfiguration : DbEntityConfiguration<Page>
    {
        public override void Configure(EntityTypeBuilder<Page> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).HasMaxLength(255).IsRequired();
            // etc.
        }
    }
}
