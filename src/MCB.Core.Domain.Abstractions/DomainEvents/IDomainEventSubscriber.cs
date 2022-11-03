using MCB.Core.Domain.Entities.Abstractions.DomainEvents;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.Observer;

namespace MCB.Core.Domain.Abstractions.DomainEvents;

public interface IDomainEventSubscriber
    : ISubscriber<IDomainEvent>
{
    IEnumerable<IDomainEvent> DomainEventCollection { get; }
}