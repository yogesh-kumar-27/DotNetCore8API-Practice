using EFDBfirst.Models;

namespace EFDBfirst.Repository.IRepository
{
    public interface ISupplier:IRepository<Supplier>
    {
        void update(Supplier supplier);
    }
}
