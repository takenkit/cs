using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConfigTest
{
    public class ConnectionConfigSection : ConfigurationSection
    {
        [ConfigurationProperty("scheme")]
        public SchemeConfigElement Scheme
        {
            get
            {
                return this["scheme"] as SchemeConfigElement;
            }
        }
        [ConfigurationProperty("guest")]
        public HostConfigElement Gueset
        {
            get
            {
                return this["guest"] as HostConfigElement;
            }
        }
        [ConfigurationProperty("host")]
        public HostConfigElement Host
        {
            get
            {
                return this["host"] as HostConfigElement;
            }
        }
        [ConfigurationProperty("hosts")]
        public HostConfigElementCollection Hosts
        {
            get
            {
                return this["hosts"] as HostConfigElementCollection;
            }
        }
    }
}
