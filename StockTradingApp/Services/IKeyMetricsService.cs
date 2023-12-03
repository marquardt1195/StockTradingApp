using StockTradingApp.Data;

namespace StockTradingApp.Services
{
    public interface IKeyMetricsService
    {
        List<KeyMetrics> GetKeyMetrics();
    }
}
