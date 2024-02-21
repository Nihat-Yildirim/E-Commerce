namespace ServiceCorePackages.ServiceCore.Application.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}