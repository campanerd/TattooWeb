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
        if (command.Description is not null) service.Description = command.Description;
        if (command.DurationMinutes is not null) service.DurationMinutes = command.DurationMinutes.Value;
        if (command.Price is not null) service.Price = command.Price.Value;

        return await repository.UpdateAsync(service);
    }
}