using Microsoft.EntityFrameworkCore;
using TattooWeb.Domain.Entities;
using TattooWeb.Domain.Repositories;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Infrastructure.Repositories;

public class ClientRepository(TattooWebDbContext db) : BaseRepository<Client>(db), IClientRepository
{
    public async Task<Client?> FindByCpfAsync(string cpf) =>
        await Db.Clients.FirstOrDefaultAsync(c => c.Cpf == cpf);

    public async Task<Client?> FindByEmailAsync(string email) =>
        await Db.Clients.FirstOrDefaultAsync(c => c.Email == email);

    public async Task<Client?> FindByPhoneAsync(string phone) =>
        await Db.Clients.FirstOrDefaultAsync(c => c.Phone == phone);
}