using TattooWeb.Domain.Entities;

namespace TattooWeb.Domain.Repositories;

public interface IServiceRepository : IBaseRepository<Service>
{
    Task<Service?> FindByNameAsync(String name);
}