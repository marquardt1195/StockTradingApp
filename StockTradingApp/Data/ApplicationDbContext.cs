using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Trade> Trades { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        public DbSet<KeyMetricsViewModel> KeyMetrics { get; set; }

        public DbSet<Account> Account { get; set; }

        public DbSet<PrincipalTest> PrincipalTest { get; set; }

        public DbSet<NetResultViewModel> NetResultViewModel { get; set; }

        public DbSet<MonthlyResultViewModel> MonthlyResultViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trade>()
                .HasMany(t => t.Transactions)
                .WithOne(t => t.Trade)
                .HasForeignKey(t => t.TradeId);

            modelBuilder.Entity<KeyMetricsViewModel>()
                .HasNoKey();

            modelBuilder.Entity<NetResultViewModel>()
                .HasNoKey();

            modelBuilder.Entity<MonthlyResultViewModel>()
                .HasNoKey();

            modelBuilder.Entity<PrincipalTest>()
                .HasNoKey();

        }
    }

}
