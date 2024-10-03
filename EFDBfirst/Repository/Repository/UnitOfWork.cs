using EFDBfirst.Models;
using EFDBfirst.Repository.IRepository;

namespace EFDBfirst.Repository.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NorthwindContext context;
        public ISupplier Supplier { get; private set; }

        public UnitOfWork(NorthwindContext context)
        {
            this.context = context;
            Supplier = new SupplierRepository(context);
        }


        public void save()
        {
            throw new NotImplementedException();
        }
    }
}
