using StockTradingApp.Data;

namespace StockTradingApp.Services
{
    public interface IKeyMetricsService
    {
        Task<KeyMetrics> GetKeyMetrics();

    }
}
