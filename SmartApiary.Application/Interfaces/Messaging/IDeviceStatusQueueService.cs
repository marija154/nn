using SmartApiary.Domain.Models;

namespace SmartApiary.Application.Interfaces.Messaging
{
    public interface IDeviceStatusQueueService
    {
        Task SendStatusUpdateAsync(DeviceStatus status, CancellationToken ct = default);
        Task<IReceivedMessage<DeviceStatus>?> ReceiveStatusUpdateAsync(CancellationToken ct = default);
    }
}
