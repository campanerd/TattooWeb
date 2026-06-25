using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Artists.GetAllArtists;

namespace TattooWeb.Tests.Artists;

public class GetAllArtistsUseCaseTests
{
    private readonly IArtistRepository _repository;
    private readonly GetAllArtistsUseCase _useCase;

    public GetAllArtistsUseCaseTests()
    {
        _repository = Substitute.For<IArtistRepository>();
        _useCase = new GetAllArtistsUseCase(_repository);
    }

    [Fact(DisplayName = "Returns all artists from repository")]
    public async Task ExecuteAsync_ReturnsAllArtists()
    {
        // Arrange
        var artists = new List<Artist>
        {
            new() { Id = Guid.NewGuid(), Name = "João" },
            new() { Id = Guid.NewGuid(), Name = "Maria" }
        };
        _repository.GetAllAsync().Returns(artists);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Equal(2, result.Count);
        Assert.Equal("João", result[0].Name);
        Assert.Equal("Maria", result[1].Name);
    }

    [Fact(DisplayName = "Returns empty list when no artists exist")]
    public async Task ExecuteAsync_WhenNoArtists_ReturnsEmptyList()
    {
        // Arrange
        _repository.GetAllAsync().Returns([]);

        // Act
        var result = await _useCase.ExecuteAsync();

        // Assert
        Assert.Empty(result);
    }
}
