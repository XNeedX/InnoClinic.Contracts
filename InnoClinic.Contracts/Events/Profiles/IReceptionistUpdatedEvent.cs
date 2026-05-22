namespace InnoClinic.Contracts.Events.Profiles;

public interface IReceptionistUpdatedEvent
{
    Guid ReceptionistId { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string OfficeAddress { get; }
}
