using NSubstitute;
using TattooWeb.Application.UseCases.Clients.UpdateClient;
using TattooWeb.Domain.Repositories;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Tests.Clients;

public class UpdateClientUseCaseTests
{
    private readonly IClientRepository _repository;
    private readonly UpdateClientUseCase _useCase;

    public UpdateClientUseCaseTests()
    {
        _repository = Substitute.For<IClientRepository>();
        _useCase = new UpdateClientUseCase(_repository);
    }
    
    [Fact(DisplayName = "Returns null when client does not exist")]
    
    public async Task ExecuteAsync_WithInvalidId_ReturnsNull()
    {
        // Arrange
        var command = new UpdateClientCommand(Guid.NewGuid(), "New Name", null, null, null);
        _repository.GetByIdAsync(command.Id).Returns((Client?)null);

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Null(result);
    }
    
    [Fact(DisplayName = "Updates only the fields provided")]
    public async Task ExecuteAsync_WithValidId_UpdatesOnlyProvidedFields()
    {
        // Arrange
        var client = new Client { Id = Guid.NewGuid(), Name = "Old Name", Phone = "11999990000" };
        var command = new UpdateClientCommand(client.Id, "New Name", null, null, null);
        _repository.GetByIdAsync(client.Id).Returns(client);
        _repository.UpdateAsync(Arg.Any<Client>()).Returns(x => x.Arg<Client>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("New Name", result.Name);
        Assert.Equal("11999990000", result.Phone);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}