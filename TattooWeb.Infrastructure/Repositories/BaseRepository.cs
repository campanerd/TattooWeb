using Microsoft.EntityFrameworkCore;
using TattooWeb.Domain.Repositories;
using TattooWeb.Infrastructure.Data;

namespace TattooWeb.Infrastructure.Repositories;

public class BaseRepository<T>(TattooWebDbContext db) : IBaseRepository<T> where T : class
{
    protected readonly TattooWebDbContext Db = db;

    public async Task<List<T>> GetAllAsync() =>
        await Db.Set<T>().ToListAsync();

    public async Task<T?> GetByIdAsync(Guid id) =>
        await Db.Set<T>().FindAsync(id);

    public async Task<T> AddAsync(T entity)
    {
        Db.Set<T>().Add(entity);
        await Db.SaveChangesAsync();
        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        Db.Set<T>().Update(entity);
        await Db.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(Guid id)
    {
        var entity = await GetByIdAsync(id);
        if (entity is not null)
        {
            Db.Set<T>().Remove(entity);
            await Db.SaveChangesAsync();
        }
    }
}