using NSubstitute;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Clients.DeleteClient;

namespace TattooWeb.Tests.Clients;

public class DeleteClientUseCaseTests
{
    private readonly IClientRepository _repository;
    private readonly DeleteClientUseCase _useCase;

    public DeleteClientUseCaseTests()
    {
        _repository = Substitute.For<IClientRepository>();
        _useCase = new DeleteClientUseCase(_repository);
    }
    
    [Fact(DisplayName = "Delete client by id")]
    public async Task ExecuteAsync_WithValidData_CallsDeleteOnRepository()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _useCase.ExecuteAsync(id);

        // Assert
        await _repository.Received(1).DeleteAsync(id);
    }
    
 
}