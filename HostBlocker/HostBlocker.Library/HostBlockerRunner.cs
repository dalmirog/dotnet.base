using Microsoft.Extensions.Logging;
using Serilog;

namespace HostBlocker.Library
{
    public class HostBlockerRunner : IHostBlockerRunner
    {
        private readonly ILogger<HostBlockerRunner> _logger;
        private readonly IFileHandler fileHandler;

        public HostBlockerRunner(ILogger<HostBlockerRunner> logger,IFileHandler fileHandler)
        {
            _logger = logger;
            this.fileHandler = fileHandler;
        }

        public IEnumerable<Site> Run(SiteAction action)
        {
            var sites = new List<Site>();
            var sitesToUpdate = fileHandler.GetSites();

            foreach (var site in sitesToUpdate)
            {

            };

            _logger.LogInformation("Hello from logger from runner!");
            return sites;
        }
    }
}
