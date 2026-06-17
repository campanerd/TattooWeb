using TattooWeb.Domain.Enums;

namespace TattooWeb.Application.UseCases.Artists.UpdateArtist;

public record UpdateArtistCommand(
    Guid Id,
    string? Name,
    ArtistSpecialty? Specialty,
    string? Bio,
    string? Phone,
    bool? Active
);
