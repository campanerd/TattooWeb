using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Clients.CreateClient;

namespace TattooWeb.Tests.Clients;

public class CreateClientUseCaseTests
{
    private readonly IClientRepository _repository;
    private readonly CreateClientUseCase _useCase;

    public CreateClientUseCaseTests()
    {
        _repository = Substitute.For<IClientRepository>();
        _useCase = new CreateClientUseCase(_repository);
    }

    [Fact(DisplayName = "Creates client and returns with correct data")]
    public async Task ExecuteAsync_WithValidData_ReturnsClientWithCorrectData()
    {
        // Arrange
        var command = new CreateClientCommand("123.456.789-00", "Carlton Rodrigues", "carlton@email.com", "11999990000", null);
        _repository.AddAsync(Arg.Any<Client>()).Returns(x => x.Arg<Client>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Equal(command.Cpf, result.Cpf);
        Assert.Equal(command.Name, result.Name);
        Assert.Equal(command.Email, result.Email);
    }
}
