using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Services
{
    public interface IResultService
    {
        Task<KeyMetrics> GetKeyMetrics();

        Task<NetResultViewModel> GetNetResults();

        NetResultViewModel GetTestResults();
    }
}
