using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Services.Interfaces
{
    public interface ITradeService
    {
        Task<List<Trade>> GetAllTrades();

        Trade GetTradeById(int StockId);

        void UpdateTrade(Trade trade);

        void AddTrade(Trade trade);

        void DeleteTrade(int StockId);

        List<Trade> GetTradeBySymbol(string pStockSymbol);

        Task<List<TradesWithPnlViewModel>> GetTradeWithPnlBySymbol(string pStockSymbol);

        Task<List<Trade>> GetAllExistingTrades();

        int RemoveRecentTrade();

        Task<List<TradesWithPnlViewModel>> GetTradesWithPnl();

        Task<List<CumulativePnlPositionViewModel>> GetCumulativePnl();

        Task<List<PositionsViewModel>> GetPositions();

        Task<List<RecentlyClosedTradesViewModel>> GetRecentlyClosed();
    }
}
