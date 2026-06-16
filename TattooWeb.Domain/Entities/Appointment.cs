using TattooWeb.Domain.Enums;

namespace TattooWeb.Domain.Entities;

public class Appointment
{
    public Guid Id { get; set; }
    public Guid ClientId { get; set; }
    public Guid ArtistId { get; set; }
    public Guid ServiceId { get; set; }
    public DateTime ScheduledAt { get; set; }
    public int DurationMinutes { get; set; }
    public AppointmentStatus Status { get; set; } = AppointmentStatus.Pending;
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? UpdatedAt { get; set; }

    public Client Client { get; set; } = null!;
    public Artist Artist { get; set; } = null!;
    public Service Service { get; set; } = null!;
    public ICollection<AppointmentHistory> History { get; set; } = [];
}