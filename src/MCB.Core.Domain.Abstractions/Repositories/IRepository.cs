using MCB.Core.Domain.Entities.Abstractions;

namespace MCB.Core.Domain.Abstractions.Repositories;

public interface IRepository<TAggregationRoot>
    where TAggregationRoot : IAggregationRoot
{

}