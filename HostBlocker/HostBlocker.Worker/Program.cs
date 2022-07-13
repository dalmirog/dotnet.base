using HostBlocker.Worker;
using HostBlocker.Library;

using Serilog;

var configuration = new ConfigurationBuilder()
  .AddJsonFile("appsettings.json")
  .Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)    
    .CreateLogger();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((hostContext,services) =>
    {
        IConfiguration config = hostContext.Configuration;
        var options = new HostBlockerOptions(
            hostFilePath: config.GetValue<string>("HOSTBLOCKER_HOSTFILEPATH"),
            sitesFilePath: config.GetValue<string>("HOSTBLOCKER_SITESFILEPATH")
        );

        services.AddSingleton(options);
        services.AddSingleton<IFileHandler, FileHandler>();
        services.AddSingleton<IHostBlockerRunner, HostBlockerRunner>();
        services.AddHostedService<Worker>();        
    })
    .ConfigureLogging( logging =>
    {
        logging.ClearProviders();        
        logging.AddSerilog();
    }
    )
    .Build();

await host.RunAsync();
