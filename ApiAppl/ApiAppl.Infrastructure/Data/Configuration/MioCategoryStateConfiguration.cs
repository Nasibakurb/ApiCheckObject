using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApiAppl.Infrastructure.Data.Configuration
{
    internal class MioCategoryStateConfiguration : IEntityTypeConfiguration<MioCategoryState>
    {
        public void Configure(EntityTypeBuilder<MioCategoryState> builder)
        {
            builder.ToTable("[kzhi].[MioCategoryState]");
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.MIOCategory)
                .WithMany()
                .HasForeignKey(e => e.MioCategoryId);

            builder.HasOne(e => e.PnStatus)
                .WithMany()
                .HasForeignKey(e => e.PnStatusId);

            builder.HasOne(e => e.MioCategoryStateChenges)
                .WithMany()
                .HasForeignKey(e => e.StateChangeId);
        }
    }
}
