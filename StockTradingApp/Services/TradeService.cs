using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;
using StockTradingApp.Services;


namespace StockTradingApp
{
    public class TradeService : ITradeService
    {
        private readonly ApplicationDbContext _dbContext;

        public TradeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Trade>> GetAllTrades()
        {
            //var calculateCostBasis = "EXEC sp_getWeightAvg";
            //return _dbContext.Trades.FromSqlRaw(calculateCostBasis).ToList();
            return _dbContext.Trades.OrderByDescending(transactions => transactions.TradeId).ToList();
        }

        public async Task<List<Trade>> GetAllExistingTrades()
        {
            return _dbContext.Trades.OrderByDescending(transactions => transactions.TradeId).ToList();
        }

        public void AddTrade(Trade trade)
        {
            _dbContext.Trades.Add(trade);
        }

        public Trade GetTradeById(int TradeId) 
        {
            return _dbContext.Trades.SingleOrDefault(x => x.TradeId == TradeId);
        }

        public List<Trade> GetTradeBySymbol(string pStockSymbol)
        {
            return _dbContext.Trades.Where(x => x.StockSymbol.Contains(pStockSymbol)).ToList();
        }

        public void DeleteTrade(int TradeId)
        {
            var trade = GetTradeById(TradeId);
            _dbContext.Trades.Remove(trade);
            _dbContext.SaveChanges();
        }

        public void UpdateTrade(Trade updatedTrade)
        {
            var existingTrade = GetTradeById(updatedTrade.TradeId);

            existingTrade.TradeId = updatedTrade.TradeId;
            existingTrade.StockSymbol = updatedTrade.StockSymbol;
            existingTrade.BuyPrice = updatedTrade.BuyPrice;
            existingTrade.NumberSharesBought = updatedTrade.NumberSharesBought;
            existingTrade.ShareBuyDate = updatedTrade.ShareBuyDate;
            existingTrade.DollarStopLoss = updatedTrade.DollarStopLoss;
            existingTrade.SellPrice = updatedTrade.SellPrice;
            existingTrade.NumberSharesSold = updatedTrade.NumberSharesSold;
            existingTrade.ShareSellDate = updatedTrade.ShareSellDate;
        }

        public int GetNextTradeId(int pTradeId)
        {
            int lastTradeId = Convert.ToInt32(_dbContext.Trades.SingleOrDefault(x=>x.TradeId == pTradeId));
            return lastTradeId;
        }
    }
}
