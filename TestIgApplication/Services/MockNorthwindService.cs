using IgApplication.Models.Northwind;

namespace IgApplication.Northwind
{
    public class MockNorthwindService : INorthwindService
    {
        public Task<List<CustomersType>> GetCustomers()
        {
            return Task.FromResult<List<CustomersType>>(new());
        }

        public Task<List<EmployeesType>> GetEmployees()
        {
            return Task.FromResult<List<EmployeesType>>(new());
        }

        public Task<List<OrdersType>> GetOrders()
        {
            return Task.FromResult<List<OrdersType>>(new());
        }
    }
}
