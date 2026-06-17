using TattooWeb.Domain.Entities;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Api.GraphQL.Queries;

[ExtendObjectType("Query")]
public class ClientQuery
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Client> GetClients([Service] TattooWebDbContext db) =>
        db.Clients;
}
