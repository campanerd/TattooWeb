using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Clients.GetAllClients;

public class GetAllClientsUseCase(IClientRepository repository)
{
    public async Task<List<Client>> ExecuteAsync() =>
        await repository.GetAllAsync();
}
