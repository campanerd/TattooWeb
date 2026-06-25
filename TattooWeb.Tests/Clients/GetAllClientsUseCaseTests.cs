using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Clients.GetAllClients;

namespace TattooWeb.Tests.Clients;

public class GetAllClientsUseCaseTests
{
    private readonly IClientRepository _repository;
    private readonly GetAllClientsUseCase _useCase;

    public GetAllClientsUseCaseTests()
    {
        _repository = Substitute.For<IClientRepository>();
        _useCase = new GetAllClientsUseCase(_repository);
    }

    [Fact(DisplayName = "Returns all clients from repository")]
    public async Task ExecuteAsync_ReturnsAllClients()
    {
        // Arrange
        var clients = new List<Client>
        {
            new() { Id = Guid.NewGuid(), Name = "João" },
            new() { Id = Guid.NewGuid(), Name = "Maria" }
        };
        _repository.GetAllAsync().Returns(clients);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("João", result[0].Name);
        Assert.Equal("Maria", result[1].Name);
    }

    [Fact(DisplayName = "Returns empty list when no clients exist")]
    public async Task ExecuteAsync_WhenNoClients_ReturnsEmptyList()
    {
        // Arrange
        _repository.GetAllAsync().Returns([]);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Empty(result);
    }
}
