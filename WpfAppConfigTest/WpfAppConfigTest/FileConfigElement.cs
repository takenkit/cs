using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConfigTest
{
    public class FileConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
        }

        [ConfigurationProperty("path")]
        public string Path
        {
            get
            {
                return this["path"] as string;
            }
        }
    }
}
