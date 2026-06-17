using TattooWeb.Domain.Entities;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Api.GraphQL.Queries;

public class ArtistQuery
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Artist> GetArtists([Service] TattooWebDbContext db) =>
        db.Artists;
}