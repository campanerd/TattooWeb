using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Artists.UpdateArtist;

namespace TattooWeb.Tests.Artists;

public class UpdateArtistUseCaseTests
{
    private readonly IArtistRepository _repository;
    private readonly UpdateArtistUseCase _useCase;

    public UpdateArtistUseCaseTests()
    {
        _repository = Substitute.For<IArtistRepository>();
        _useCase = new UpdateArtistUseCase(_repository);
    }

    [Fact(DisplayName = "Returns null when artist does not exist")]
    public async Task ExecuteAsync_WithInvalidId_ReturnsNull()
    {
        // Arrange
        var command = new UpdateArtistCommand(Guid.NewGuid(), "New Name", null, null, null, null);
        _repository.GetByIdAsync(command.Id).Returns((Artist?)null);

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Null(result);
    }

    [Fact(DisplayName = "Updates only the fields provided")]
    public async Task ExecuteAsync_WithValidId_UpdatesOnlyProvidedFields()
    {
        // Arrange
        var artist = new Artist { Id = Guid.NewGuid(), Name = "Old Name", Phone = "11999990000" };
        var command = new UpdateArtistCommand(artist.Id, "New Name", null, null, null, null);
        _repository.GetByIdAsync(artist.Id).Returns(artist);
        _repository.UpdateAsync(Arg.Any<Artist>()).Returns(x => x.Arg<Artist>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.NotNull(result);
        Assert.Equal("New Name", result.Name);
        Assert.Equal("11999990000", result.Phone);
    }
}
