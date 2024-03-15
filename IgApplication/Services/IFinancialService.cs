using IgApplication.Models.Financial;

namespace IgApplication.Financial
{
    public interface IFinancialService
    {
        Task<List<BoxOfficeRevenueType>> GetBoxOfficeRevenue();
        Task<List<StocksType>> GetStocks();
    }
}
