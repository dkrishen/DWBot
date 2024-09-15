using DWBot.Infrastructure.Abstract;
using Microsoft.Extensions.Logging;

namespace DWBot.Services;

// Compose Polling and ReceiverService implementations
internal class PollingService : PollingServiceBase<ReceiverService>
{
    public PollingService(IServiceProvider serviceProvider, ILogger<PollingService> logger)
        : base(serviceProvider, logger)
    {
    }
}
