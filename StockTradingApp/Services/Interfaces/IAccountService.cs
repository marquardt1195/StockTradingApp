using StockTradingApp.Data;

namespace StockTradingApp.Services.Interfaces
{
    public interface IAccountService
    {
        Task<Account> GetPrincipalBal();

        void UpdatePrincipalBal(Account account);
    }
}
