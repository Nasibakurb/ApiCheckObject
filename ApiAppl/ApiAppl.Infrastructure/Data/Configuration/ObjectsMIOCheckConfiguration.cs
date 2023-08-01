using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class ObjectsMIOCheckConfiguration : IEntityTypeConfiguration<ObjectsMIOCheck>
    {
        public void Configure(EntityTypeBuilder<ObjectsMIOCheck> builder)
        {
            builder.ToTable("[kzhi].[ObjectsMIOCheck]");
          
        }
    }
}
