namespace InnoClinic.Contracts.Events.Profiles;

public interface IDoctorUpdatedEvent
{
    Guid DoctorId { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string Specialization { get; }
    string OfficeAddress { get; }
    string Status { get; }
}
