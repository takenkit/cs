using System.Configuration;

namespace WpfAppConfigTest
{
    public  class SchemeConfigElement : ConfigurationElement
    {
        [ConfigurationProperty("kind", IsRequired = true)]
        public string Kind
        {
            get
            {
                return this["kind"] as string;
            }
        }
    }
}