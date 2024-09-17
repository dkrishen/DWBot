using DWBot.Data.Repositories;
using DWBot.Domain.Repositories;
using DWBot.Infrastructure.Options;
using DWBot.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Telegram.Bot;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddOptions<BotConfigurationOptions>()
            .BindConfiguration(BotConfigurationOptions.SectionName)
            .ValidateOnStart();

        services.AddSerilog(asdf => asdf.ReadFrom.Configuration(context.Configuration));

        services.AddHttpClient("telegram_bot_client")
            .AddTypedClient<ITelegramBotClient>((httpClient, sp) =>
            {
                BotConfigurationOptions? botConfig = sp.GetConfiguration<BotConfigurationOptions>();
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
