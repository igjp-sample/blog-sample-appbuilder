using IgApplication.Models.Northwind;

namespace IgApplication.Northwind
{
    public interface INorthwindService
    {
        Task<List<CustomersType>> GetCustomers();
        Task<List<EmployeesType>> GetEmployees();
        Task<List<OrdersType>> GetOrders();
    }
}
