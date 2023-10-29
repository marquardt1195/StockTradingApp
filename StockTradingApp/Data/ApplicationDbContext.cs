using Microsoft.EntityFrameworkCore;

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

        public virtual DbSet<Trade> Trades { get; set; }

        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Your entity configurations should go here
            modelBuilder.Entity<Trade>()
                .HasMany(t => t.Transactions)
                .WithOne(t => t.Trade)
                .HasForeignKey(t => t.TradeId);

            // Other entity configurations...

            // This is where you configure the relationships and other settings.
        }
    }

}
