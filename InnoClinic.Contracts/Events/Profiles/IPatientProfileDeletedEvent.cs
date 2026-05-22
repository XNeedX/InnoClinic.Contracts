namespace InnoClinic.Contracts.Events.Profiles;

public interface IPatientProfileDeletedEvent
{
    Guid PatientId { get; }
}
