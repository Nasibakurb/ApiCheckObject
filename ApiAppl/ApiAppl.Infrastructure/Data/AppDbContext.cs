using ApiAppl.Infrastructure.Data.Configuration;
using ApiAppl.Domain.Entity;
using ApiAppl.Domain.Entity.Logger;
using Microsoft.EntityFrameworkCore;

namespace ApiAppl.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
           // Database.EnsureCreated();
        }

        public DbSet<ObjectsMIOCheck> ObjectsChecks { get; set; }
        public DbSet<MIOCategory> MIOCategories { get; set; }
        public DbSet<MioCategoryState> MioCategoryStates { get; set; }
        public DbSet<MioCategoryStateChenges> MioCategoryStateChanges { get; set; }
        public DbSet<PriorityObjectHistory> PriorityObjectHistories { get; set; }
        public DbSet<PriorityObjects> PriorityObjects { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Logger> loggers { get; set; }
        public DbSet<Pn_Object> Pn_Objects { get; set; }
        public DbSet<BoProgramm> BOPROGRAMM { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new MIOCategoryConfiguration());
            //modelBuilder.ApplyConfiguration(new MioCategoryStateConfiguration()); // Ссылка на отдельный класс
            //modelBuilder.ApplyConfiguration(new MioCategoryStateChangeConfiguration());
            //modelBuilder.ApplyConfiguration(new PnStatusConfiguration());
            //modelBuilder.ApplyConfiguration(new PriorityObjectConfiguration());
            //modelBuilder.ApplyConfiguration(new PriorityObjectHistoryConfiguration());
            ////modelBuilder.ApplyConfiguration(new ObjectsMIOCheckConfiguration());
            //modelBuilder.ApplyConfiguration(new UserConfiguration());
            //modelBuilder.ApplyConfiguration(new Object_codeConfiguration());

        }
    }
    }


