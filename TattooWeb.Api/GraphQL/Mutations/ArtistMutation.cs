using TattooWeb.Application.UseCases.Artists.CreateArtist;
using TattooWeb.Application.UseCases.Artists.DeleteArtist;
using TattooWeb.Application.UseCases.Artists.UpdateArtist;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Api.GraphQL.Mutations;

public class ArtistMutation
{
    public async Task<Artist> CreateArtist(
        CreateArtistCommand command,
        [Service] CreateArtistUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<Artist?> UpdateArtist(
        UpdateArtistCommand command,
        [Service] UpdateArtistUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<bool> DeleteArtist(
        Guid id,
        [Service] DeleteArtistUseCase useCase)
    {
        await useCase.ExecuteAsync(id);
        return true;
    }
}