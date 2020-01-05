using System;
using System.Diagnostics.CodeAnalysis;
using CSharpWars.Common.Configuration.Interfaces;
using CSharpWars.Model;
using Microsoft.EntityFrameworkCore;

namespace CSharpWars.DataAccess
{
    [ExcludeFromCodeCoverage]
    public class CSharpWarsDbContext : DbContext
    {
        private readonly IConfigurationHelper _configurationHelper;

        public DbSet<Player> Players { get; set; }

        public DbSet<Bot> Bots { get; set; }

        public DbSet<BotScript> BotScripts { get; set; }

        public DbSet<Message> Messages { get; set; }

        public CSharpWarsDbContext(IConfigurationHelper configurationHelper)
        {
            _configurationHelper = configurationHelper;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (String.IsNullOrEmpty(_configurationHelper.ConnectionString))
            {
                optionsBuilder.UseInMemoryDatabase($"{Guid.NewGuid()}");
            }
            else
            {
                optionsBuilder.UseSqlServer(_configurationHelper.ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>(e =>
            {
                e.ToTable("PLAYERS").HasKey(x => x.Id).ForSqlServerIsClustered(false);
                e.Property<Int32>("SysId").UseSqlServerIdentityColumn();
                e.HasIndex("SysId").ForSqlServerIsClustered();
                e.Property(x => x.LastDeployment).IsRequired();
            });

            modelBuilder.Entity<Bot>(e =>
            {
                e.ToTable("BOTS").HasKey(x => x.Id).ForSqlServerIsClustered(false);
                e.Property<Int32>("SysId").UseSqlServerIdentityColumn();
                e.HasIndex("SysId").ForSqlServerIsClustered();
            });

            modelBuilder.Entity<BotScript>(e =>
            {
                e.ToTable("BOTS").HasKey(x => x.Id).ForSqlServerIsClustered(false);
                e.HasOne<Bot>().WithOne().HasForeignKey<BotScript>(x => x.Id);
            });

            modelBuilder.Entity<Message>(e =>
            {
                e.ToTable("MESSAGES").HasKey(x => x.Id).ForSqlServerIsClustered(false);
                e.Property<Int32>("SysId").UseSqlServerIdentityColumn();
                e.HasIndex("SysId").ForSqlServerIsClustered();
            });
        }
    }
}