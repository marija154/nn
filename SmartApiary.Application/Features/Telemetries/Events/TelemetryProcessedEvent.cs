using MediatR;
using SmartApiary.Domain.Models;

namespace SmartApiary.Application.Features.Telemetries.Events
{
    public record TelemetryProcessedEvent(Telemetry Telemetry) : INotification;
}
