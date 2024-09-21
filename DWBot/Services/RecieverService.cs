using DWBot.Abstract;
using Microsoft.Extensions.Logging;
using Telegram.Bot;

namespace DWBot.Services;

// Compose Receiver and UpdateHandler implementation
internal class ReceiverService : ReceiverServiceBase<UpdateHandler>
{
    public ReceiverService(
        ITelegramBotClient botClient,
        UpdateHandler updateHandler,
        ILogger<ReceiverServiceBase<UpdateHandler>> logger)
        : base(botClient, updateHandler, logger)
    {
    }
}
