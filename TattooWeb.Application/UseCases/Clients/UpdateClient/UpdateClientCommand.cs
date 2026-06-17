namespace TattooWeb.Application.UseCases.Clients.UpdateClient;

public record UpdateClientCommand(
    Guid Id,
    string? Name,
    string? Email,
    string? Phone,
    string? Allergy
    );