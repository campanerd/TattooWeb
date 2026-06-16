using Microsoft.EntityFrameworkCore;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Infrastructure.Repositories;

public class ArtistRepository(TattooWebDbContext db) : BaseRepository<Artist>(db), IArtistRepository
{
    public async Task<Artist?> FindByCpfAsync(string cpf) =>
        await Db.Artists.FirstOrDefaultAsync(a => a.Cpf == cpf);
}