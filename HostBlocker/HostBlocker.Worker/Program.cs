using HostBlocker.Worker;
using HostBlocker.Library;

using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Seq("http://localhost:5341")//should come from config file
    .WriteTo.Console()
    .CreateLogger();

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IFileHandler, FileHandler>(x => new FileHandler("","")); //should come from config
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
