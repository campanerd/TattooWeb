using Microsoft.EntityFrameworkCore;
using TattooWeb.Domain.Entities;

namespace TattooWeb.Infrastructure.Data;

public class TattooWebDbContext : DbContext
{
    public TattooWebDbContext(DbContextOptions<TattooWebDbContext> options) : base(options) { }

    public DbSet<Artist> Artists => Set<Artist>();
    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Service> Services => Set<Service>();
    public DbSet<Appointment> Appointments => Set<Appointment>();
    public DbSet<AppointmentHistory> AppointmentHistories => Set<AppointmentHistory>();
}