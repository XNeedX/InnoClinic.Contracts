namespace InnoClinic.Contracts.Events.Profiles;

public interface IDoctorCreatedEvent
{
    Guid Id { get; }
    string Email { get; }
    string FirstName { get; }
    string LastName { get; }
    string? MiddleName { get; }
    DateTime DateOfBirth { get; }     
    string Specialization { get; }
    int CareerStartYear { get; }      
    string OfficeAddress { get; }
}