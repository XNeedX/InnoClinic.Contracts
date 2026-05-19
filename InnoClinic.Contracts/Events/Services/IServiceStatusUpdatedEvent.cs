using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Services;

public interface IServiceStatusUpdatedEvent
{
    Guid Id { get; }
    ServiceStatus Status { get; }
}