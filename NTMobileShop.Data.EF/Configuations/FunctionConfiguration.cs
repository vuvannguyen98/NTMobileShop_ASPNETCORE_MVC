using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NTMobileShop.Data.EF.Extensions;
using NTMobileShop.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NTMobileShop.Data.EF.Configuations
{
    public class FunctionConfiguration : DbEntityConfiguration<Function>
    {
        public override void Configure(EntityTypeBuilder<Function> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Id).IsRequired()
                .HasMaxLength(128).IsUnicode(false);
            // etc.
        }
    }
}
