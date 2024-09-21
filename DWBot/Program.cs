using DWBot.Data.Extensions;
using DWBot.Infrastructure.Extenshions;
using DWBot.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.RegisterInfrastructureLayerDependencies(context);
        services.RegisterDataLayerDependencies();

        services.AddScoped<UpdateHandler>();
        services.AddScoped<ReceiverService>();

        services.AddHostedService<PollingService>();
    })
    .Build();

host.ExecuteDataLayerInitializationActions();

await host.RunAsync();
