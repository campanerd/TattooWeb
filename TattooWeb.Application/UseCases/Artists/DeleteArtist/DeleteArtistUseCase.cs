using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.DeleteArtist;

public class DeleteArtistUseCase(IArtistRepository repository)
{
    public async Task ExecuteAsync(Guid id) =>
        await repository.DeleteAsync(id);
}
