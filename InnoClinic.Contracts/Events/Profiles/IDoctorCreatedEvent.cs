namespace InnoClinic.Contracts.Events.Profiles;

public interface IDoctorCreatedEvent
{
    Guid DoctorId { get; }
    string Email { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string Specialization { get; }
    string OfficeAddress { get; }
}
