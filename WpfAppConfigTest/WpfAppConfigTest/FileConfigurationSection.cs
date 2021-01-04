using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConfigTest
{
    public class FileConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("file1")]
        public FileConfigElement File1
        {
            get
            {
                return this["file1"] as FileConfigElement;
            }
        }

        [ConfigurationProperty("file2")]
        public FilesConfigElement File2
        {
            get
            {
                return this["file2"] as FilesConfigElement;
            }
        }
    }
}
