using StockTradingApp.Data;

namespace StockTradingApp.Services
{
    public interface ITransactionService
    {
        public Task<List<Transaction>> GetAllTransactions();

        Transaction GetTransactionById(int transactionId);

        public Task<List<Transaction>> GetTransactionByTradeId(int pTradeId);

        void UpdateTransaction(Transaction transaction);

        void AddTransaction(Transaction transaction);

        void DeleteTransaction(int transactionId);
    }
}
