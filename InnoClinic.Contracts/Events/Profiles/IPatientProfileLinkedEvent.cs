namespace InnoClinic.Contracts.Events.Profiles;

public interface IPatientProfileLinkedEvent
{
    Guid Id { get; }
    string AccountId { get; }
}
