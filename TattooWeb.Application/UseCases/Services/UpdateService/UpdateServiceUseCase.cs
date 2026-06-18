using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
namespace TattooWeb.Application.UseCases.Services.UpdateService;

public class UpdateServiceUseCase(IServiceRepository repository)
{
    public async Task<Service?> ExecuteAsync(UpdateServiceCommand command)
    {
        var service = await repository.GetByIdAsync(command.Id);
        if (service is null) return null;

        if (command.Name is not null) service.Name = command.Name;

        return await repository.UpdateAsync(service);
    }
}