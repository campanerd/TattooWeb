using TattooWeb.Application.UseCases.Services.CreateService;
using TattooWeb.Application.UseCases.Services.DeleteService;
using TattooWeb.Application.UseCases.Services.UpdateService;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Api.GraphQL.Mutations;

[ExtendObjectType("Mutation")]
public class ServiceMutation
{
    public async Task<Service> CreateService(CreateServiceCommand command, [Service] CreateServiceUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<Service?> UpdateService(UpdateServiceCommand command, [Service] UpdateServiceUseCase useCase) =>
        await useCase.ExecuteAsync(command);

    public async Task<bool> DeleteService(Guid id, [Service] DeleteServiceUseCase useCase)
    {
        await useCase.ExecuteAsync(id);
        return true;
    }
}
