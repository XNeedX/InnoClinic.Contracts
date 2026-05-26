namespace InnoClinic.Contracts.Events.Profiles;

public interface IPatientCreatedEvent
{
    Guid Id { get; }
    string AccountId { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string PhoneNumber { get; }
    DateTime DateOfBirth { get; }
}
