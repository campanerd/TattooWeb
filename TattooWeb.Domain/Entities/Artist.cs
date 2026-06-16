namespace TattooWeb.Domain.Entities;

public class Artist
{
    public Guid Id { get; set; }
    public string Cpf { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Specialty { get; set; }
    public string? Bio { get; set; }
    public string? Phone { get; set; }
    public bool Active { get; set; } = true;
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public ICollection<Appointment> Appointments { get; set; } = [];
}