using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.GetAllArtists;

public class GetAllArtistsUseCase(IArtistRepository repository)
{
    public async Task<List<Artist>> ExecuteAsync() =>
        await repository.GetAllAsync();
}
