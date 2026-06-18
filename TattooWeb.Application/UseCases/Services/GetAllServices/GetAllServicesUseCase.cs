using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Services.GetAllServices;

public class GetAllServicesUseCase(IServiceRepository repository)
{
    public async Task<List<Service>> ExecuteAsync() =>
        await repository.GetAllAsync();   
}