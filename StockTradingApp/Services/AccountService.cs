using Microsoft.EntityFrameworkCore;
using StockTradingApp.Data;
using StockTradingApp.Services;

namespace StockTradingApp.Services
{
    public class AccountService : IAccountService
    {
        private readonly ApplicationDbContext _dbContext;

        public AccountService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Account> GetPrincipalBal()
        {
            return  _dbContext.Account.SingleOrDefault();
        }

        public async void UpdatePrincipalBal(Account updatedAccount)
        {
            var existingAccount =  await GetPrincipalBal();

            existingAccount.Id = updatedAccount.Id;
            existingAccount.principal_balance = updatedAccount.principal_balance;
            existingAccount.principal_start_date = updatedAccount.principal_start_date;
        }

    }
}
