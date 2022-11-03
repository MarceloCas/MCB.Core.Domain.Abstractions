
using MCB.Core.Domain.Entities.Abstractions.DomainEvents;

namespace MCB.Core.Domain.Abstractions.DomainEvents;

public interface IDomainEventPublisher
{
    Task PublishDomainEventAsync(IDomainEvent domainEvent, CancellationToken cancellationToken);
}