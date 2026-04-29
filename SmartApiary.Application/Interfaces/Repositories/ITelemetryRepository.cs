using SmartApiary.Domain.Models;

namespace SmartApiary.Application.Interfaces.Repositories
{
    public interface ITelemetryRepository
    {
        Task SaveAsync(Telemetry telemetry, CancellationToken ct = default);
    }
}
