using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.UpdateArtist;

public class UpdateArtistUseCase(IArtistRepository repository)
{
    public async Task<Artist?> ExecuteAsync(UpdateArtistCommand command)
    {
        var artist = await repository.GetByIdAsync(command.Id);
        if (artist is null) return null;

        if (command.Name is not null) artist.Name = command.Name;
        if (command.Specialty is not null) artist.Specialty = command.Specialty;
        if (command.Bio is not null) artist.Bio = command.Bio;
        if (command.Phone is not null) artist.Phone = command.Phone;
        if (command.Active is not null) artist.Active = command.Active.Value;

        return await repository.UpdateAsync(artist);
    }
}
