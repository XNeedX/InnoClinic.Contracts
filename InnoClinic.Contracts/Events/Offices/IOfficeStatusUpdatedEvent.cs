using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Offices;

public interface IOfficeStatusUpdatedEvent
{
    OfficeStatus Status { get; }
}
