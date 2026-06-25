using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Services.GetAllServices;

namespace TattooWeb.Tests.Services;

public class GetAllServicesUseCaseTests
{
    private readonly IServiceRepository _repository;
    private readonly GetAllServicesUseCase _useCase;

    public GetAllServicesUseCaseTests()
    {
        _repository = Substitute.For<IServiceRepository>();
        _useCase = new GetAllServicesUseCase(_repository);
    }

    [Fact(DisplayName = "Returns all services from repository")]
    public async Task ExecuteAsync_ReturnsAllServices()
    {
        // Arrange
        var services = new List<Service>
        {
            new() { Id = Guid.NewGuid(), Name = "Blackwork" },
            new() { Id = Guid.NewGuid(), Name = "Fineline" }
        };
        _repository.GetAllAsync().Returns(services);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("Blackwork", result[0].Name);
        Assert.Equal("Fineline", result[1].Name);
    }

    [Fact(DisplayName = "Returns empty list when no services exist")]
    public async Task ExecuteAsync_WhenNoServices_ReturnsEmptyList()
    {
        // Arrange
        _repository.GetAllAsync().Returns([]);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Empty(result);
    }
}
