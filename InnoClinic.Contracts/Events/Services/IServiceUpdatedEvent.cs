using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Services;

public interface IServiceUpdatedEvent
{
    Guid Id { get; }
    string Name { get; }
    decimal Price { get; }
    ServiceCategory Category { get; }
    ServiceStatus Status { get; }
    Guid SpecializationId { get; }
}