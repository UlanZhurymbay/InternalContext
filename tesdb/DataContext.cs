using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using tesdb;

namespace WebApplication1
{
    internal class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Other> Others { get; set; }

        private string connection;
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
            AppContext.SetSwitch("Npgsql.DisableDateTimeInfinityConversions", true);
        }

        public DataContext(string connection)
        {
            this.connection = connection;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql(this.connection);
            }
        }
    }
}
