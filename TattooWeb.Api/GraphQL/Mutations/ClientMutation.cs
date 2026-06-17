using TattooWeb.Application.UseCases.Clients.CreateClient;
using TattooWeb.Application.UseCases.Clients.DeleteClient;
using TattooWeb.Application.UseCases.Clients.UpdateClient;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Api.GraphQL.Mutations;

[ExtendObjectType("Mutation")]
public class ClientMutation
{
    public async Task<Client> CreateClient(
        CreateClientCommand command,
        [Service] CreateClientUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<Client?> UpdateClient(
        UpdateClientCommand command,
        [Service] UpdateClientUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<bool> DeleteClient(
        Guid id,
        [Service] DeleteClientUseCase useCase)
    {
        await useCase.ExecuteAsync(id);
        return true;
    }
}
