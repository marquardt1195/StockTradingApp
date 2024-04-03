using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;
using StockTradingApp.Pages;
using StockTradingApp.Services.Interfaces;


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
            var calculateCostBasis = "EXEC sp_getWeightAvg";
            return _dbContext.Trades.FromSqlRaw(calculateCostBasis).ToList();
        }

        public async Task<List<TradesWithPnlViewModel>> GetTradesWithPnl()
        {
            var getTradesWithPnl = "EXEC sp_getTradesWithPnl";
            var tradesWithPnl = _dbContext.TradesWithPnlViewModel.FromSqlRaw(getTradesWithPnl).ToList();
            var orderedTrades = tradesWithPnl.OrderByDescending(trade => trade.TradeId).ToList();
            return orderedTrades;
        }

        public async Task<List<Trade>> GetAllExistingTrades()
        {
            return await _dbContext.Trades.OrderByDescending(trade => trade.TradeId).ToListAsync();
        }

        public void AddTrade(Trade trade)
        {
            _dbContext.Trades.Add(trade);
            _dbContext.SaveChanges();
        }

        public Trade GetTradeById(int TradeId) 
        {
            return _dbContext.Trades.SingleOrDefault(x => x.TradeId == TradeId);
        }

        public List<Trade> GetTradeBySymbol(string pStockSymbol)
        {
            return _dbContext.Trades.Where(x => x.StockSymbol.Contains(pStockSymbol)).ToList();
        }

        public async Task<List<TradesWithPnlViewModel>> GetTradeWithPnlBySymbol(string pStockSymbol)
        {
            var getTradesWithPnl = "EXEC sp_getTradesWithPnl";
            var tradesWithPnl = _dbContext.TradesWithPnlViewModel.FromSqlRaw(getTradesWithPnl).ToList();
            var filteredTrades = tradesWithPnl.Where(x => x.StockSymbol != null && x.StockSymbol.ToLower().Contains(pStockSymbol.ToLower())).ToList();
            return filteredTrades;
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

        public int RemoveRecentTrade()
        {
            var maxTrade = _dbContext.Trades.OrderByDescending(t => t.TradeId).FirstOrDefault();

            // Check if any trades exist
            if (maxTrade != null)
            {
                _dbContext.Trades.Remove(maxTrade);
                _dbContext.SaveChanges();
                return maxTrade.TradeId;
            }
            return 0;
        }

        public async Task<List<CumulativePnlPositionViewModel>> GetCumulativePnl()
        {
            var getTradesWithPnl = "EXEC sp_plotTradePnl";
            //var tradesWithPnl = _dbContext.CumulativePnlPositionVM.FromSqlRaw(getTradesWithPnl).ToList();
            return _dbContext.CumulativePnlPositionVM.FromSqlRaw(getTradesWithPnl).ToList();
            //var orderedTrades = tradesWithPnl.OrderByDescending(trade => trade.TradeId).ToList();
            //return orderedTrades;
        }

        public async Task<List<PositionsViewModel>> GetPositions()
        {
            var getPositions = "EXEC sp_getPositions";
            var positions = _dbContext.PositionsViewModel.FromSqlRaw(getPositions).ToList();
            var orderedByPos = positions.OrderByDescending(trade => trade.PositionSize).ToList();
            return orderedByPos;

        }

        public async Task<List<RecentlyClosedTradesViewModel>> GetRecentlyClosed()
        {
            var getRecentlyClosed = "EXEC sp_getRecentlyClosed";
            return _dbContext.RecentlyClosedTradeViewModel.FromSqlRaw(getRecentlyClosed).ToList();

        }

    }
}
