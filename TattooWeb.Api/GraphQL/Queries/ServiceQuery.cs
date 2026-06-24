using TattooWeb.Domain.Entities;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Api.GraphQL.Queries;

[ExtendObjectType("Query")]
public class ServiceQuery
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<Service> GetServices([Service] TattooWebDbContext db) =>
        db.Services;
}