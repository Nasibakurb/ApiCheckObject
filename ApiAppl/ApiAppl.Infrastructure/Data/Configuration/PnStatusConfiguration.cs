using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class PnStatusConfiguration : IEntityTypeConfiguration<PnStatus>
    {
        public void Configure(EntityTypeBuilder<PnStatus> builder)
        {
            builder.ToTable("PnStatus");

            builder.HasKey(e => e.Id);
        }
    }
}
