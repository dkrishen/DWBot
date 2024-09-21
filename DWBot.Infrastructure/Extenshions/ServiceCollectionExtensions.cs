using DWBot.Infrastructure.Options;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Telegram.Bot;

namespace DWBot.Infrastructure.Extenshions;

public static class ServiceCollectionExtensions
{
    public static void RegisterInfrastructureLayerDependencies(this IServiceCollection services, HostBuilderContext context)
    {
        services.AddSerilog(asdf => asdf.ReadFrom.Configuration(context.Configuration));

        services.AddOptions<BotConfigurationOptions>()
            .BindConfiguration(BotConfigurationOptions.SectionName)
            .ValidateOnStart();

        services.AddHttpClient("telegram_bot_client")
            .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
            {
                BotConfigurationOptions? botConfig = sp.GetConfiguration<BotConfigurationOptions>();
                TelegramBotClientOptions options = new(botConfig.BotToken);
                return new TelegramBotClient(options, httpClient);
            });
    }
}
