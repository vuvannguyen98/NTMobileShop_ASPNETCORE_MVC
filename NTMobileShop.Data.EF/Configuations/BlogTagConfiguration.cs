using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileShop.Data.EF.Extensions;
using NTMobileShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.EF.Configuations
{
    public class BlogTagConfiguration : DbEntityConfiguration<BlogTag>
    {
        public override void Configure(EntityTypeBuilder<BlogTag> entity)
        {
            entity.Property(c => c.TagId).HasMaxLength(50).IsRequired()
            .IsUnicode(false).HasMaxLength(50);
            // etc.
        }
    }
}
