using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Clients.DeleteClient;

public class DeleteClientUseCase(IClientRepository repository)
{
    public async Task ExecuteAsync(Guid id) =>
        await repository.DeleteAsync(id);
}
