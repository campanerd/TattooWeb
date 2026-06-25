using NSubstitute;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Artists.DeleteArtist;

namespace TattooWeb.Tests.Artists;

public class DeleteArtistUseCaseTests
{
    private readonly IArtistRepository _repository;
    private readonly DeleteArtistUseCase _useCase;

    public DeleteArtistUseCaseTests()
    {
        _repository = Substitute.For<IArtistRepository>();
        _useCase = new DeleteArtistUseCase(_repository);
    }

    [Fact(DisplayName = "Delete artist by id")]
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