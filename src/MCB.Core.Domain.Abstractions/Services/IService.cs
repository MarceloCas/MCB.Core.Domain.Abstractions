using MCB.Core.Domain.Entities.Abstractions;

namespace MCB.Core.Domain.Abstractions.Services;

public interface IService<TAggregationRoot>
    where TAggregationRoot : IAggregationRoot
{
}