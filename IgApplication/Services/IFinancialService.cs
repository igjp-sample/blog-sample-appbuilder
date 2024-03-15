using IgApplication.Models.Financial;

namespace IgApplication.Financial
{
    public interface IFinancialService
    {
        Task<List<StocksType>> GetStocks();
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
    }
}
