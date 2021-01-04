using System.Configuration;

namespace WpfAppConfigTest
{
    public class FilesConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("name")]
        public string Name
        {
            get
            {
                return this["name"] as string;
            }
        }
        [ConfigurationProperty("filename")]
        public string Filename
        {
            get
            {
                return this["filename"] as string;
            }
        }
        [ConfigurationProperty("files")]
        public FileConfigElementCollection Files
        {
            get
            {
                return this["files"] as FileConfigElementCollection;
            }
        }
    }
}