using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.ExecutionInfo;

namespace MCB.Core.Domain.Abstractions.Services.Inputs;

public readonly record struct ServiceInputBase
{
    // Properties
    public ExecutionInfo ExecutionInfo { get; }

    // Constructors
    public ServiceInputBase(ExecutionInfo executionInfo)
    {
        ExecutionInfo = executionInfo;
    }
    public ServiceInputBase(ref ExecutionInfo executionInfo)
    {
        ExecutionInfo = executionInfo;
    }
}