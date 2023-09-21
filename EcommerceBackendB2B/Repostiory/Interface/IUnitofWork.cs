namespace EcommerceBackendB2B.Repostiory.Interface
{
    public interface IUnitofWork : IDisposable
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task<int> SaveChangesAsync();
    }
}
