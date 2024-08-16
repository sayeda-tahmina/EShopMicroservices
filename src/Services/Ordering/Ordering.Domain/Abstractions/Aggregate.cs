
namespace Ordering.Domain.Abstractions
{
    public abstract class Aggregate<TId> : Entity<TId>, IAggregate<TId>
    {
        private readonly List<IDomainEvent> _domainevents = new();
        public IReadOnlyList<IDomainEvent> DomainEvents => _domainevents.AsReadOnly();

        public void AddDomainEvent(IDomainEvent domainEvent)
        {
            _domainevents.Add(domainEvent);
        }

        public IDomainEvent[] ClearDomainEvents()
        {
            IDomainEvent[] dequeuedEvents = _domainevents.ToArray();

            _domainevents.Clear();

            return dequeuedEvents;
        }
    }
}
