namespace TattooWeb.Application.UseCases.Artists.CreateArtist;

public record CreateArtistCommand(
    string Cpf,
    string Name,
    string? Specialty,
    string? Bio,
    string? Phone
);

