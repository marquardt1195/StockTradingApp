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

        //public DbSet<TradeViewModel> TradeViewModel { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Trade>()
                .HasMany(t => t.Transactions)
                .WithOne(t => t.Trade)
                .HasForeignKey(t => t.TradeId);
        }
    }

}
