using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Services.CreateService;

namespace TattooWeb.Tests.Services;

public class CreateServiceUseCaseTests
{
    private readonly IServiceRepository _repository;
    private readonly CreateServiceUseCase _useCase;

    public CreateServiceUseCaseTests()
    {
        _repository = Substitute.For<IServiceRepository>();
        _useCase = new CreateServiceUseCase(_repository);
    }

    [Fact(DisplayName = "Creates service and returns with correct data")]
    public async Task ExecuteAsync_WithValidData_ReturnsServiceWithCorrectData()
    {
        // Arrange
        var command = new CreateServiceCommand("Blackwork", "Tatuagem em preto sólido", 120, 350.00m);
        _repository.AddAsync(Arg.Any<Service>()).Returns(x => x.Arg<Service>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Equal(command.Name, result.Name);
        Assert.Equal(command.Price, result.Price);
        Assert.Equal(command.DurationMinutes, result.DurationMinutes);
    }

    [Fact(DisplayName = "Throws when a service with the same name already exists")]
    public async Task ExecuteAsync_WithDuplicateName_ThrowsInvalidOperation()
    {
        // Arrange
        var command = new CreateServiceCommand("Blackwork", "Tatuagem em preto sólido", 120, 350.00m);
        _repository.FindByNameAsync(command.Name).Returns(new Service { Name = command.Name });

        // Act + Assert
        await Assert.ThrowsAsync<InvalidOperationException>(() => _useCase.ExecuteAsync(command));
        await _repository.DidNotReceive().AddAsync(Arg.Any<Service>());
    }
}
