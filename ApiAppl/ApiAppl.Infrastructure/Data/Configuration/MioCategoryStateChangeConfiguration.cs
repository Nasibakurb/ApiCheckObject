using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class MioCategoryStateChangeConfiguration : IEntityTypeConfiguration<MioCategoryStateChenges>
    {
        public void Configure(EntityTypeBuilder<MioCategoryStateChenges> builder)
        {
            builder.ToTable("[kzhi].[MioCategoryStateChanges]");

            builder.HasKey(e => e.Id);

        }

    }
}
