using TattooWeb.Domain.Entities;

namespace TattooWeb.Domain.Repositories;

public interface IClientRepository : IBaseRepository<Client>
{
    Task<Client?> FindByCpfAsync(string cpf);
    Task<Client?> FindByEmailAsync(string email);
}