using EFDBfirst.Models;

namespace EFDBfirst.Repository.IRepository
{
    public interface ICustomerRepository
    {
        public Task<List<Customer>> GetCustomers();
        public Task<Customer> GetById(string id);

        public Task Create(Customer customer);
        public Task Update(Customer customer);
        public Task Delete(Customer customer);
    }
}
