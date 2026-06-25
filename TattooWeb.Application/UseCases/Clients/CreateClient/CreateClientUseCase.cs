using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;

namespace TattooWeb.Application.UseCases.Clients.CreateClient;

public class CreateClientUseCase(IClientRepository repository)
{
    public async Task<Client> ExecuteAsync(CreateClientCommand command)
    {
        var existingCpf = await repository.FindByCpfAsync(command.Cpf);
        if (existingCpf is not null)
            throw new InvalidOperationException("A client with this CPF already exists.");

        var existingEmail = await repository.FindByEmailAsync(command.Email);
        if (existingEmail is not null)
            throw new InvalidOperationException("A client with this email already exists.");

        var client = new Client
        {
            Id = Guid.NewGuid(),
            Cpf = command.Cpf,
            Name = command.Name,
            Email = command.Email,
            Allergy = command.Allergy,
            Phone = command.Phone
        };

        return await repository.AddAsync(client);
    }
}
