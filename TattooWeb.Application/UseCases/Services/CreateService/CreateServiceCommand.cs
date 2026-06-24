namespace TattooWeb.Application.UseCases.Services.CreateService;

public record CreateServiceCommand
(
    string Name,
    string? Description,
    int DurationMinutes,
    decimal Price
);