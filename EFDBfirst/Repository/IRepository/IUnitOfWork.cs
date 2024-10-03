namespace EFDBfirst.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ISupplier Supplier { get; }
        void save();
    }
}
