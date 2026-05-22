using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Services; 

public interface ISpecializationStatusUpdatedEvent 
{ 
    Guid Id { get; } 
    ServiceStatus Status { get; } 
}