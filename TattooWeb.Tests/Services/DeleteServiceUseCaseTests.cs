using NSubstitute;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Services.DeleteService;

namespace TattooWeb.Tests.Services;

public class DeleteServiceUseCaseTests
{
    private readonly IServiceRepository _repository;
    private readonly DeleteServiceUseCase _useCase;

    public DeleteServiceUseCaseTests()
    {
        _repository = Substitute.For<IServiceRepository>();
        _useCase = new DeleteServiceUseCase(_repository);
    }

    [Fact(DisplayName = "Delete service by id")]
    public async Task ExecuteAsync_WithValidId_CallsDeleteOnRepository()
    {
        // Arrange
        var id = Guid.NewGuid();

        // Act
        await _useCase.ExecuteAsync(id);

        // Assert
        await _repository.Received(1).DeleteAsync(id);
    }
}
