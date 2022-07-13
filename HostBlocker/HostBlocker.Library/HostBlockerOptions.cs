using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostBlocker.Library
{
    public class HostBlockerOptions
    {
        public string HostFilePath { get; set; }
        public string SitesFilePath { get; set; }

        public HostBlockerOptions(string hostFilePath, string sitesFilePath)
        {
            ArgumentNullException.ThrowIfNull(hostFilePath);
            ArgumentNullException.ThrowIfNull(sitesFilePath);

            HostFilePath = hostFilePath;
            SitesFilePath = sitesFilePath;  
        }
    }
}
