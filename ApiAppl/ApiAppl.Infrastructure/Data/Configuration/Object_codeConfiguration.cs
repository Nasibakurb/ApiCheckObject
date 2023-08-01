using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Enum;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class Object_codeConfiguration : IEntityTypeConfiguration<Pn_Object>
    {
        public void Configure(EntityTypeBuilder<Pn_Object> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(new Pn_Object[]
            {
                new Pn_Object()
                {
                    Id = 1,
                    Code = 1
                },
                new Pn_Object()
                {
                    Id = 2,
                    Code = 2
                },
            });
        }
    }
}
