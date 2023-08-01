using System;
using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class PriorityObjectConfiguration : IEntityTypeConfiguration<PriorityObjects>
    {
        public void Configure(EntityTypeBuilder<PriorityObjects> builder)
        {
            builder.ToTable("[kzhi].[PriorityObjects]");

            builder.HasKey(e => e.Id);

            builder.HasOne<Domain.Entity.PnStatus>()
                .WithMany()
                .HasForeignKey(e => e.PnStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Pn_Object>()
                .WithMany()
                .HasForeignKey(e => e.PnObjectId)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
