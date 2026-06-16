using TattooWeb.Domain.Entities;

namespace TattooWeb.Domain.Repositories;

public interface IArtistRepository : IBaseRepository<Artist>
{
    Task<Artist?> FindByCpfAsync(string cpf);
}