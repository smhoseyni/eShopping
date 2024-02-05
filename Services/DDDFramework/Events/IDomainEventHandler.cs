namespace DDDFramework.Core.Domain.Events
{
    public interface IDomainEventHandler<TEvent> where TEvent : IDomainEvent
    {
        Task HandleAsync(TEvent @event);
    }
}
