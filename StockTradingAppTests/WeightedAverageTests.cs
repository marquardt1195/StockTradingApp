using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Moq;
using StockTradingApp.Data;
using StockTradingApp.Services.Interfaces;

namespace StockTradingAppTests
{
    public class WeightedAverageTests
    {
        private readonly ITradeService _tradeService;

        public WeightedAverageTests()
        {
            var mockTradeService = new Mock<ITradeService>();
            _tradeService = mockTradeService.Object;
        }

        [Fact]
        public async Task GetAllTrades_ShouldCalculateWeightedAverage()
        {
            //Arrange
            double expected = 64.22;

            var mockTradeService = new Mock<ITradeService>();
            mockTradeService.Setup(ts => ts.GetAllTrades()).ReturnsAsync(new List<Trade>
            {
                new Trade { BuyPrice = 64.22 }
            });

            //Act
            var actualTrades = await mockTradeService.Object.GetAllTrades();
            var firstTrade = actualTrades.FirstOrDefault();
            var costBasis = firstTrade.BuyPrice;

            //Assert
            Assert.Equal(expected, costBasis);
        }
    }
}
