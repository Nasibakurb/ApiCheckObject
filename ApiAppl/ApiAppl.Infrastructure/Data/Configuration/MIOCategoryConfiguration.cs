using ApiAppl.Domain.Entity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using ApiAppl.Domain.Enum;

namespace ApiAppl.Infrastructure.Data.Configuration
{
    public class MIOCategoryConfiguration : IEntityTypeConfiguration<MIOCategory>
    {
        public void Configure(EntityTypeBuilder<MIOCategory> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasData(new MIOCategory[]
            {
                new MIOCategory()
                {
                    Id = 1,
                    Name = "Социально-уязвимые слои населения",
                    SubName = "Инвалиды 1-2 группы",
                    LastChange = "",
                    DateCreated = DateTime.Now,
                    DateChange = DateTime.Now,
                    StatusNameCategory = Status.Accepted

                },
                new MIOCategory()
                {
                    Id = 2,
                    Name = "Социально-уязвимые слои населения",
                    SubName = "Семьи, имеющие или воспитывающие детей-инвалидов",
                    LastChange = "",
                    DateCreated = DateTime.Now,
                    DateChange = DateTime.Now,
                    StatusNameCategory = Status.Accepted
                },
                new MIOCategory()
                {
                    Id = 3,
                    Name = "Многодетные семьи",
                    SubName = "Многодетные семьи",
                    LastChange = "",
                    DateCreated = DateTime.Now,
                    DateChange = DateTime.Now,
                    StatusNameCategory = Status.Accepted
                },
                new MIOCategory()
                {
                    Id = 4,
                    Name = "Дети-сироты",
                    SubName = "Социально-уязвимые слои населения",
                    LastChange = "",
                    DateCreated = DateTime.Now,
                    DateChange = DateTime.Now,
                    StatusNameCategory = Status.Accepted

                }
            }) ;
        }
    }
}

