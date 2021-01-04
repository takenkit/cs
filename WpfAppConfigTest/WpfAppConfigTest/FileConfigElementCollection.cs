using System.Configuration;

namespace WpfAppConfigTest
{
    public class FileConfigElementCollection : ConfigurationElementCollection
    {
        public FileConfigElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as FileConfigElement;
            }
        }
        protected override ConfigurationElement CreateNewElement()
        {
            return new FileConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((FileConfigElement)(element)).Name;
        }
    }
}