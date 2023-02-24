using FluentAssertions;
using MCB.Core.Domain.Abstractions.Services.Inputs;
using MCB.Core.Infra.CrossCutting.DesignPatterns.Abstractions.ExecutionInfo;
using System;
using Xunit;

namespace MCB.Core.Domain.Abstractions.Tests.ServicesTests.InputsTests;

public class ServiceInputBaseTest
{
    [Fact]
    public void ServiceInputBase_Should_Correctly_Initialized()
    {
        // Arrange
        var correlationId = Guid.NewGuid();
        var tenantId = Guid.NewGuid();
        var executionUser = Guid.NewGuid().ToString();
        var sourcePlatform = Guid.NewGuid().ToString();

        var executionInfo = new ExecutionInfo
        (
            correlationId,
            tenantId,
            executionUser,
            sourcePlatform
        );

        // Act
        var serviceInputA = new ServiceInputBase(executionInfo);
        var serviceInputB = new ServiceInputBase(ref executionInfo);

        // Assert
        serviceInputA.ExecutionInfo.TenantId.Should().Be(tenantId);
        serviceInputA.ExecutionInfo.ExecutionUser.Should().Be(executionUser);
        serviceInputA.ExecutionInfo.SourcePlatform.Should().Be(sourcePlatform);
        serviceInputA.ExecutionInfo.Should().NotBe(executionUser);

        serviceInputB.ExecutionInfo.TenantId.Should().Be(tenantId);
        serviceInputB.ExecutionInfo.ExecutionUser.Should().Be(executionUser);
        serviceInputB.ExecutionInfo.SourcePlatform.Should().Be(sourcePlatform);
        serviceInputA.ExecutionInfo.Should().NotBe(executionUser);
    }
}

