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

        public List<KeyMetrics> GetKeyMetrics()
        {
           // var key_metrics = "EXEC sp_getKeyMetrics";
           // return _dbContext.KeyMetrics.FromSqlRaw(key_metrics).SingleOrDefault();
            return _dbContext.KeyMetrics.ToList();
        }

    }
}
