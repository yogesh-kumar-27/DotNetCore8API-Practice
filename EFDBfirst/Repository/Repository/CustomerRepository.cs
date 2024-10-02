using EFDBfirst.Models;
using EFDBfirst.Repository.IRepository;
using Microsoft.EntityFrameworkCore;

namespace EFDBfirst.Repository.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly NorthwindContext northwindContext;

        public CustomerRepository(NorthwindContext northwindContext)
        {
            this.northwindContext = northwindContext;
        }

        public async Task Create(Customer customer)
        {
            await northwindContext.Customers.AddAsync(customer);
            await northwindContext.SaveChangesAsync();
        }

        public async Task Delete(Customer customer)
        {
            northwindContext.Customers.Remove(customer);
            await northwindContext.SaveChangesAsync();
        }

        public async Task<Customer> GetById(string id)
        {
            return await northwindContext.Customers.FindAsync(id);
        }

        public async Task<List<Customer>> GetCustomers()
        {
            var data = await northwindContext.Customers.ToListAsync();
            return data;
        }

        public async Task Update(Customer customer)
        {
            northwindContext.Customers.Update(customer);
            await northwindContext.SaveChangesAsync();
        }
    }
}
