namespace InnoClinic.Contracts.Events.Profiles;

public interface IReceptionistCreatedEvent
{
    Guid ReceptionistId { get; }
    string Email { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string OfficeAddress { get; }
}
