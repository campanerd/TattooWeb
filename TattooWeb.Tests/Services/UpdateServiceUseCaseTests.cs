using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Services.UpdateService;

namespace TattooWeb.Tests.Services;

public class UpdateServiceUseCaseTests
{
    private readonly IServiceRepository _repository;
    private readonly UpdateServiceUseCase _useCase;

    public UpdateServiceUseCaseTests()
    {
        _repository = Substitute.For<IServiceRepository>();
        _useCase = new UpdateServiceUseCase(_repository);
    }

    [Fact(DisplayName = "Returns null when service does not exist")]
    public async Task ExecuteAsync_WithInvalidId_ReturnsNull()
    {
        // Arrange
        var command = new UpdateServiceCommand(Guid.NewGuid(), "New Name", null, null, null);
        _repository.GetByIdAsync(command.Id).Returns((Service?)null);

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Null(result);
    }

    [Fact(DisplayName = "Updates only the fields provided")]
    public async Task ExecuteAsync_WithValidId_UpdatesOnlyProvidedFields()
    {
        // Arrange
        var service = new Service { Id = Guid.NewGuid(), Name = "Old Name", Price = 200.00m };
        var command = new UpdateServiceCommand(service.Id, "New Name", null, null, null);
        _repository.GetByIdAsync(service.Id).Returns(service);
        _repository.UpdateAsync(Arg.Any<Service>()).Returns(x => x.Arg<Service>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("New Name", result.Name);
        Assert.Equal(200.00m, result.Price);
    }
}
