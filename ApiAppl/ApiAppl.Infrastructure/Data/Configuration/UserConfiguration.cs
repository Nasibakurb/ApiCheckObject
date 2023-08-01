using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiAppl.Infrastructure.Data.Configuration
{ 
public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("[kzhi].[User]");
        builder.HasKey(e => e.Id);


        builder.HasData(new User[]
        {
            new User()
            {
                Id = 1
            },
            new User()
            {
                Id = 2
            },
            new User()
            {
                Id = 3
            },
            new User()
            {
                Id = 4

            }
        });
    }
}
}
