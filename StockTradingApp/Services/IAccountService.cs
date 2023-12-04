using StockTradingApp.Data;
namespace StockTradingApp.Services
{
    public interface IAccountService
    {
        Task<Account> GetPrincipalBal();

        void UpdatePrincipalBal(Account account);
    }
}
