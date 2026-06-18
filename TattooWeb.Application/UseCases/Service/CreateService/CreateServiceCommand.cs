namespace TattooWeb.Application.UseCases.Service.CreateService;

public record CreateServiceCommand
(
    string Cpf,
    string? Description,
    int DurationMinutes,
    int Price
);