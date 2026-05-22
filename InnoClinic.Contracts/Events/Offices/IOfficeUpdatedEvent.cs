using InnoClinic.Contracts.Enums;

namespace InnoClinic.Contracts.Events.Offices;

public interface IOfficeUpdatedEvent
{
    string? PhotoPath { get; }
    string City { get; }
    string Street { get; }
    string HouseNumber { get; }
    string? OfficeNumber { get; }
    string RegistryPhoneNumber { get; }
    OfficeStatus Status { get; }
}
