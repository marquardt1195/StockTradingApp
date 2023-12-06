using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;

namespace StockTradingApp.Services.Interfaces
{
    public interface ITransactionService
    {
        public Task<List<Transaction>> GetAllTransactions();

        Transaction GetTransactionById(int transactionId);

        public Task<List<Transaction>> GetTransactionByTradeId(int pTradeId);

        void UpdateTransaction(Transaction transaction);

        void AddTransaction(Transaction transaction);

        void DeleteTransaction(int transactionId);

        // public Task<IEnumerable<TradeViewModel>> TradeTransactionCalculations(int tradeId);
    }
}
