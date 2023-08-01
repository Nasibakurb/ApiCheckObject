using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class PriorityObjectHistoryConfiguration : IEntityTypeConfiguration<PriorityObjectHistory>
    {
        public void Configure(EntityTypeBuilder<PriorityObjectHistory> builder)
        {
            builder.ToTable("[kzhi].[PriorityObjectHistory]");

           builder.HasKey(e => e.Id);
           
            builder.HasOne<Domain.Entity.PnStatus>()
                .WithMany()
                .HasForeignKey(e => e.OldPnStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Domain.Entity.PnStatus>()
                .WithMany()
                .HasForeignKey(e => e.NewPnStatusId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne<Pn_Object>()
              .WithMany()
              .HasForeignKey(e => e.PriorityObjectId)
              .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
