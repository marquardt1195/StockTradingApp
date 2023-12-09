using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Services.Interfaces
{
    public interface IResultService
    {
        Task<KeyMetricsViewModel> GetKeyMetrics();

        Task<NetResultViewModel> GetNetResults();

        Task<List<MonthlyResultViewModel>> GetMonthlyResults();

        Task<List<MonthlyResultViewModel>> GetMonthlyTestResults();

        Task<List<PrincipalTest>> GetPrincipalTest();
    }
}
