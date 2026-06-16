using TattooWeb.Domain.Enums;

namespace TattooWeb.Application.UseCases.Artists.CreateArtist;

public record CreateArtistCommand(
    string Cpf,
    string Name,
    ArtistSpecialty? Specialty,
    string? Bio,
    string? Phone
);

