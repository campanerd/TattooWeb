using TattooWeb.Domain.Entities;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Application.UseCases.Artists.CreateArtist;

public class CreateArtistUseCase(TattooWebDbContext db)
{
    public async Task<Artist> ExecuteAsync(CreateArtistCommand command)
    {
        var artist = new Artist
        {
            Id = Guid.NewGuid(),
            Cpf = command.Cpf,
            Name = command.Name,
            Specialty = command.Specialty,
            Bio = command.Bio,
            Phone = command.Phone
        };

        db.Artists.Add(artist);
        await db.SaveChangesAsync();

        return artist;
    }
}