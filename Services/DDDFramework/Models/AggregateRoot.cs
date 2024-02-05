using DDDFramework.Core.Domain.Events;

namespace DDDFramework.Core.Domain.Models
{
    public class AggregateRoot<TAggregateRoot, TId> : BaseEntity<TAggregateRoot, TId>, IEventfulEntity
        where TAggregateRoot : AggregateRoot<TAggregateRoot, TId>
        where TId : struct
    {
        private readonly List<IDomainEvent> _domainEvents;
        protected AggregateRoot()
        {
            _domainEvents = new();
        }
        protected void AddEvent(IDomainEvent @event) => _domainEvents.Add(@event);
        protected void RemoveEvent(IDomainEvent @event) => _domainEvents?.Remove(@event);
        public void ClearEvents() => _domainEvents?.Clear();
        public IReadOnlyCollection<IDomainEvent> GetEvents() => _domainEvents.AsReadOnly();
    }
}
