using IgApplication.Models.Financial;

namespace IgApplication.Financial
{
    public class MockFinancialService : IFinancialService
    {
        public Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue()
        {
            return Task.FromResult<List<BoxOfficeRevenueType>>(new());
        }

        public Task<List<StocksType>> GetStocks()
        {
            return Task.FromResult<List<StocksType>>(new());
        }
    }
}
