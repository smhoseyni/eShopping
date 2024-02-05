namespace DDDFramework.Core.Domain.Data
{
    public interface IUnitOfWork : IDisposable
    {
        public Task<int> SaveChangesAsync();
    }
}
