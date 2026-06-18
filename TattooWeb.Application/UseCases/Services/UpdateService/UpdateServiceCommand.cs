namespace TattooWeb.Application.UseCases.Services.UpdateService;

public record UpdateServiceCommand(
    Guid Id,
    string? Name,
    string? Description,
    int DurationMinutes,
    int Price
    );