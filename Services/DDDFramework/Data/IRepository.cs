using DDDFramework.Core.Domain.Models;

namespace DDDFramework.Core.Domain.Data
{
    public interface IRepository<TEntity, TId>
        where TEntity : AggregateRoot<TEntity, TId>
        where TId : struct
    {

    }
}
