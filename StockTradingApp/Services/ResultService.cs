using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;
using StockTradingApp.Services.Interfaces;

namespace StockTradingApp.Services
{
    public class ResultService : IResultService
    {
        private readonly ApplicationDbContext _dbContext;

        public ResultService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<KeyMetricsViewModel> GetKeyMetrics()
        {
            var key_metrics = "EXEC sp_getKeyMetrics";
            //await _dbContext.Database.ExecuteSqlRawAsync(key_metrics);
            //return await _dbContext.KeyMetrics.FromSqlRaw(key_metrics).SingleOrDefaultAsync();
            //return _dbContext.KeyMetrics.SingleOrDefault();

            return _dbContext.KeyMetrics.FromSqlRaw(key_metrics).AsEnumerable().SingleOrDefault();
        }

        public async Task<NetResultViewModel> GetNetResults()
        {
            var net_results = "EXEC sp_getNetResults";
            return _dbContext.NetResultViewModel.FromSqlRaw(net_results).AsEnumerable().SingleOrDefault();
        }

    }
}
