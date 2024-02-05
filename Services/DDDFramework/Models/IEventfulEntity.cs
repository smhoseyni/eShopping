using DDDFramework.Core.Domain.Events;

namespace DDDFramework.Core.Domain.Models
{
    public interface IEventfulEntity
    {
        void ClearEvents();
        IReadOnlyCollection<IDomainEvent> GetEvents();
    }
}
