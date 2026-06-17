using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Clients.UpdateClient;

public class UpdateClientUseCase(IClientRepository repository)
{
    public async Task<Client?> ExecuteAsync(UpdateClientCommand command)
    {
        var client = await repository.GetByIdAsync(command.Id);
        if (client is null) return null;

        if (command.Name is not null) client.Name = command.Name;
        if (command.Phone is not null) client.Phone = command.Phone;
        if (command.Email is not null) client.Email = command.Email;
        if (command.Allergy is not null) client.Allergy = command.Allergy;

        return await repository.UpdateAsync(client);
    }
}
