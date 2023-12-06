using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Services.Interfaces
{
    public interface IResultService
    {
        Task<KeyMetricsViewModel> GetKeyMetrics();

        Task<NetResultViewModel> GetNetResults();
    }
}
