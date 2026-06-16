using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.CreateArtist;

public class CreateArtistUseCase(IArtistRepository repository)
{
    public async Task<Artist> ExecuteAsync(CreateArtistCommand command)
    {
        var artist = new Artist
        {
            Id = Guid.NewGuid(),
            Cpf = command.Cpf,
            Name = command.Name,
            Specialty = command.Specialty,
            Bio = command.Bio,
            Phone = command.Phone
        };

        return await repository.AddAsync(artist);
    }
}
