namespace InnoClinic.Contracts.Events.Profiles;

public interface IReceptionistUpdatedEvent
{
    Guid Id { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string OfficeAddress { get; }
}
