using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.UpdateArtist;

public class UpdateArtistUseCase(IArtistRepository repository)
{
    public async Task<Artist?> ExecuteAsync(UpdateArtistCommand command)
    {
        var artist = await repository.GetByIdAsync(command.Id);
        if (artist is null) return null;

        artist.Name = command.Name;
        artist.Specialty = command.Specialty;
        artist.Bio = command.Bio;
        artist.Phone = command.Phone;
        artist.Active = command.Active;

        return await repository.UpdateAsync(artist);
    }
}
