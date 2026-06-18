namespace InnoClinic.Contracts.Events.Profiles;

public interface IPatientUpdatedEvent
{
    Guid Id { get; }
    string AccountId { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    string PhoneNumber { get; }
    string Email { get; }
    DateTime DateOfBirth { get; }
}
