using StockTradingApp.Data;

namespace StockTradingApp.Services
{
    public interface ITradeService
    {
        public Task<List<Trade>> GetAllTrades();

        Trade GetTradeById(int StockId);

        void UpdateTrade(Trade trade);

        void AddTrade(Trade trade);

        void DeleteTrade(int StockId);
    }
}
