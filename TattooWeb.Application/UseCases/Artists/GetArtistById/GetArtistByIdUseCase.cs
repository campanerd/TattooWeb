using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Artists.GetArtistById;

public class GetArtistByIdUseCase(IArtistRepository repository)
{
    public async Task<Artist?> ExecuteAsync(Guid id) =>
        await repository.GetByIdAsync(id);
}
