using EFDBfirst.Models;
using EFDBfirst.Repository.IRepository;

namespace EFDBfirst.Repository.Repository
{
    public class SupplierRepository : Repository<Supplier>, ISupplier 
    {
        private readonly NorthwindContext northwindContext;

        public SupplierRepository(NorthwindContext northwindContext) : base(northwindContext)
        {
            this.northwindContext = northwindContext;
        }


        public void update(Supplier supplier)
        {
            northwindContext.Update(supplier);
        }

    }
}
