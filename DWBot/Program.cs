using DWBot.Data.Repositories;
using DWBot.Infrastructure.Extensions;
using DWBot.Models;
using DWBot.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Telegram.Bot;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.Configure<BotConfiguration>(
            context.Configuration.GetSection(BotConfiguration.Configuration));

        services.AddSerilog(asdf => asdf.ReadFrom.Configuration(context.Configuration));

        services.AddHttpClient("telegram_bot_client")
                .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
                {
                    BotConfiguration? botConfig = sp.GetConfiguration<BotConfiguration>();
                    TelegramBotClientOptions options = new(botConfig.BotToken);
                    return new TelegramBotClient(options, httpClient);
                });

        services.AddScoped<UpdateHandler>();
        services.AddScoped<ReceiverService>();

        //services.AddScoped<IStateRepository, StateRepository>();
        services.AddSingleton<IStateRepository, InMemoryStateRepository>();

        services.AddHostedService<PollingService>();
    })
    .Build();

await host.RunAsync();
