using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;
using StockTradingApp.Data.ViewModels;
using System.Linq;

namespace StockTradingApp.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ApplicationDbContext _dbContext;

        public TransactionService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            return _dbContext.Transactions.OrderByDescending(transactions => transactions.TransactionId).ToList();
        }

        public async Task<List<Transaction>> GetTransactionByTradeId(int pTradeId)
        {
            return _dbContext.Transactions.Where(x => x.TradeId == pTradeId).ToList();
        }

        public void AddTransaction(Transaction transaction)
        {
            _dbContext.Transactions.Add(transaction);
        }

        public Transaction GetTransactionById(int transactionId)
        {
            return _dbContext.Transactions.SingleOrDefault(x => x.TransactionId == transactionId);
        }


        public void DeleteTransaction(int transactionId)
        {
            var transaction = GetTransactionById(transactionId);
            _dbContext.Transactions.Remove(transaction);
            _dbContext.SaveChanges();
        }

        public void UpdateTransaction(Transaction updatedTransaction)
        {
            var existingTransaction = GetTransactionById(Convert.ToInt32(updatedTransaction.TransactionId));

            //existingTransaction.TransactionId = updatedTransaction.TransactionId;
            existingTransaction.TradeId = updatedTransaction.TradeId;
            existingTransaction.StockSymbol = updatedTransaction.StockSymbol;
            existingTransaction.EntryPrice = updatedTransaction.EntryPrice;
            existingTransaction.NumberSharesEntered = updatedTransaction.NumberSharesEntered;
            existingTransaction.EntryDate = updatedTransaction.EntryDate;
            existingTransaction.SellPrice = updatedTransaction.SellPrice;
            existingTransaction.NumberSharesExited = updatedTransaction.NumberSharesExited;
            existingTransaction.ExitDate = updatedTransaction.ExitDate;
        }

       // public Task<IEnumerable<TradeViewModel>> TradeTransactionCalculations(int tradeId)
       // {
       //     var transactions = GetTransactionByTradeId(tradeId);
       //
       //     var tradeViewModels = transactions
       //
       //
       // }
    }
}

