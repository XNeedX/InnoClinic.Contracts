namespace InnoClinic.Contracts.Events.Profiles;

public interface IPatientProfileLinkedEvent
{
    Guid PatientId { get; }
    string AccountId { get; }
}
