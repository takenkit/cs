using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConfigTest
{
    public class ViewModel
    {
        public ViewModel()
        {
            string hostname = System.Net.Dns.GetHostName();
            var connectionConfig = ConfigurationManager.GetSection("connectionConfig") as ConnectionConfigSection;
            var fileConfig = ConfigurationManager.GetSection("fileConfig") as FileConfigurationSection;
            Hosts = connectionConfig.Hosts;
        }
        public HostConfigElementCollection Hosts { get; private set; }
    }
}
