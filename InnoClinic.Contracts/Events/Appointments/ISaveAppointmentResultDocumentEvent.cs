namespace InnoClinic.Contracts.Events.Appointments;

public interface ISaveAppointmentResultDocumentEvent
{
    Guid AppointmentId { get; }
    byte[] PdfBytes { get; }
    string ContentType { get; }
}