using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Offices;

public interface IOfficeStatusUpdatedEvent
{
    Guid Id { get; }
    OfficeStatus Status { get; }
    string Address { get; }
}
