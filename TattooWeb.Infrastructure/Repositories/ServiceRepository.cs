using Microsoft.EntityFrameworkCore;
using TattooWeb.Domain.Repositories;
using TattooWeb.Infrastructure.Data;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Infrastructure.Repositories;

public class ServiceRepository (TattooWebDbContext db) : BaseRepository<Service>(db), IServiceRepository
{
    public async Task<Service?>  FindByNameAsync(string name) =>
        await Db.Services.FirstOrDefaultAsync(s => s.Name == name);
}