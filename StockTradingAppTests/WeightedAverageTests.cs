using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Moq;
using StockTradingApp.Data;
using StockTradingApp.Services.Interfaces;
using StockTradingApp.Data.ViewModels;
using StockTradingApp;

namespace StockTradingAppTests
{
    public class WeightedAverageTests 
    {
        private readonly ITradeService _tradeService;
        private readonly ApplicationDbContext _dbContext;

        public WeightedAverageTests(ApplicationDbContext dbContext, ITradeService tradeService)
        {
            _dbContext = dbContext;
            _tradeService = tradeService;

        }

        [Fact]
        public async Task GetAllTrades_ShouldCalculateWeightedAverage()
        {
            //Arrange
            var allTrades = await _tradeService.GetAllTrades();
            var firstTrade = allTrades != null ? allTrades.LastOrDefault() : null; // Add null check
            double expected = 62.22;

            // Check if firstTrade is null before accessing its properties
            if (firstTrade != null)
            {
                //Act
                var costBasis = firstTrade.BuyPrice;

                //Assert
                Assert.Equal(expected, costBasis);
            }
            else
            {
                // Handle case where allTrades is empty or null
                Assert.True(false, "No trades found."); // Fails the test indicating no trades were found
            }

        }
    }

}
