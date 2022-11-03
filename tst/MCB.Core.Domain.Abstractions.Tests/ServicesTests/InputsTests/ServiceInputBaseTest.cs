using FluentAssertions;
using MCB.Core.Domain.Abstractions.Services.Inputs;
using System;
using Xunit;

namespace MCB.Core.Domain.Abstractions.Tests.ServicesTests.InputsTests;

public class ServiceInputBaseTest
{
    [Fact]
    public void ServiceInputBase_Should_Correctly_Initialized()
    {
        // Arrange
        var tenantId = Guid.NewGuid();
        var executionUser = Guid.NewGuid().ToString();
        var sourcePlatform = Guid.NewGuid().ToString();

        // Act
        var serviceInput = new DummyServiceInput(tenantId, executionUser, sourcePlatform);

        // Assert
        serviceInput.TenantId.Should().Be(tenantId);
        serviceInput.ExecutionUser.Should().Be(executionUser);
        serviceInput.SourcePlatform.Should().Be(sourcePlatform);
    }
}

public record DummyServiceInput
    : ServiceInputBase
{
    public DummyServiceInput(
        Guid tenantId, 
        string executionUser, 
        string sourcePlatform
    ) : base(tenantId, executionUser, sourcePlatform)
    {
    }
}
