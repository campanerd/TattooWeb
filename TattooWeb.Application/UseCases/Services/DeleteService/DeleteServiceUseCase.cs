using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Services.DeleteService;

public class DeleteServiceUseCase(IServiceRepository repository)
{
    public async Task ExecuteAsync(Guid id) =>
        await repository.DeleteAsync(id);
}