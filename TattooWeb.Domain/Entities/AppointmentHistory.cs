namespace TattooWeb.Domain.Entities;

public class AppointmentHistory
{
    public Guid Id { get; set; }
    public Guid AppointmentId { get; set; }
    public string ChangedField { get; set; } = string.Empty;
    public string? PreviousValue { get; set; }
    public string? NewValue { get; set; }
    public DateTime ChangedAt { get; set; } = DateTime.UtcNow;
    public string? ChangedBy { get; set; }

    public Appointment Appointment { get; set; } = null!;
}