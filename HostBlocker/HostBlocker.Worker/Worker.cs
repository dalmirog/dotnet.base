using HostBlocker.Library;

namespace HostBlocker.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IConfiguration _config;
        private readonly IHostBlockerRunner _runner;

        public Worker(ILogger<Worker> logger, IConfiguration config, IHostBlockerRunner runner)
        {
            _logger = logger;
            _config = config;
            _runner = runner;   
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            //while (!stoppingToken.IsCancellationRequested)
            //{
            //    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
            //    await Task.Delay(1000, stoppingToken);
            //}
            _runner.Run(SiteAction.Unblock);
        }
    }
}