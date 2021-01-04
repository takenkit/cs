using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WpfAppConfigTest
{
    public class HostConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
        }

        [ConfigurationProperty("address", IsRequired = true)]
        public string Address
        {
            get
            {
                return this["address"] as string;
            }
        }

        [ConfigurationProperty("user", IsRequired = true)]
        public string User
        {
            get
            {
                return this["user"] as string;
            }
        }

        [ConfigurationProperty("pass", IsRequired = true)]
        public string Pass
        {
            get
            {
                return this["pass"] as string;
            }
        }
    }
}
