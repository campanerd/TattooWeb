namespace TattooWeb.Application.UseCases.Service.UpdateService;

public record UpdateServiceCommand(
    Guid Id,
    string Cpf,
    string? Description,
    int DurationMinutes,
    int Price
    );