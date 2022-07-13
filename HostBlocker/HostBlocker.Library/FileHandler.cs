using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostBlocker.Library
{
    public class FileHandler : IFileHandler
    {
        private readonly string hostFilePath;
        private readonly string sitesFilePath;

        public FileHandler(HostBlockerOptions options)
        {
            hostFilePath = options.HostFilePath;
            sitesFilePath = options.SitesFilePath;
        }
        public IEnumerable<Site> GetSites()
        {
            return new List<Site>();
        }

        public void WriteHostFile()
        {

        }

        public IEnumerable<Site> ReadHostFile()
        {
            return new List<Site>();
        }
    }
}
