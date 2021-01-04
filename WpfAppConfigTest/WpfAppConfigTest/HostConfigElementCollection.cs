using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppConfigTest
{
    public class HostConfigElementCollection : ConfigurationElementCollection
    {
        public HostConfigElement this[int index]
        {
            get
            {
                return base.BaseGet(index) as HostConfigElement;
            }
        }

        protected override ConfigurationElement CreateNewElement()
        {
            return new HostConfigElement();
        }

        protected override object GetElementKey(ConfigurationElement element)
        {
            return ((HostConfigElement)(element)).Name;
        }
    }
}
