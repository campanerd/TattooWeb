namespace TattooWeb.Application.UseCases.Clients.CreateClient;
public record CreateClientCommand(
    string Cpf,
    string Name,
    string Email,
    string? Phone,
    string? Allergy
);