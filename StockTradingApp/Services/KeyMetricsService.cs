using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;


namespace StockTradingApp.Services
{
    public class KeyMetricsService : IKeyMetricsService
    {
        private readonly ApplicationDbContext _dbContext;

        public KeyMetricsService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<KeyMetrics> GetKeyMetrics()
        {
            var key_metrics = "EXEC sp_getKeyMetrics";
            await _dbContext.Database.ExecuteSqlRawAsync(key_metrics);
            //return await _dbContext.KeyMetrics.FromSqlRaw(key_metrics).SingleOrDefaultAsync();
            return _dbContext.KeyMetrics.SingleOrDefault();
        }

    }
}
