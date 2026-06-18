using TattooWeb.Domain.Repositories;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Application.UseCases.Services.CreateService;

public class CreateServiceUseCase(IServiceRepository repository)
{
    public async Task<Service> ExecuteAsync(CreateServiceCommand command)
    {
        var service = new Service
        {
            Id = Guid.NewGuid(),
            Name = command.Name,
            Description = command.Description,
            DurationMinutes = command.DurationMinutes,
            Price = command.Price
        };
        return await repository.AddAsync(service);
    }
}
