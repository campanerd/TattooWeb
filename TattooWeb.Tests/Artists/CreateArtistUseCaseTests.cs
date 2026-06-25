using NSubstitute;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Application.UseCases.Artists.CreateArtist;

namespace TattooWeb.Tests.Artists;

public class CreateArtistUseCaseTests
{
    private readonly IArtistRepository _repository;
    private readonly CreateArtistUseCase _useCase;

    public CreateArtistUseCaseTests()
    {
        _repository = Substitute.For<IArtistRepository>();
        _useCase = new CreateArtistUseCase(_repository);
    }

    [Fact(DisplayName = "Creates artist and returns with correct name")]
    public async Task ExecuteAsync_WithValidData_ReturnsArtistWithCorrectName()
    {
        // Arrange
        var command = new CreateArtistCommand("123.456.789-00", "João Silva", null, null, null);
        _repository.AddAsync(Arg.Any<Artist>()).Returns(x => x.Arg<Artist>());

        // Act
        var result = await _useCase.ExecuteAsync(command);

        // Assert
        Assert.Equal(command.Name, result.Name);
        Assert.Equal(command.Cpf, result.Cpf);
    }

    [Fact(DisplayName = "Throws when an artist with the same CPF already exists")]
    public async Task ExecuteAsync_WithDuplicateCpf_ThrowsInvalidOperation()
    {
        // Arrange
        var command = new CreateArtistCommand("123.456.789-00", "João Silva", null, null, null);
        _repository.FindByCpfAsync(command.Cpf).Returns(new Artist { Cpf = command.Cpf });

        // Act + Assert
        await Assert.ThrowsAsync<InvalidOperationException>(() => _useCase.ExecuteAsync(command));
        await _repository.DidNotReceive().AddAsync(Arg.Any<Artist>());
    }
}