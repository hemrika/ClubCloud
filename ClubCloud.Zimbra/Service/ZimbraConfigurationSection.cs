using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Service
{
    public class ZimbraConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Server")]
        public ZimbraServerElement Server
        {
            get
            {
                return (ZimbraServerElement)this["Server"];
            }
            set
            { this["Server"] = value; }
        }

        [ConfigurationProperty("Binding")]
        public ZimbraBindingElement Binding
        {
            get
            {
                return (ZimbraBindingElement)this["Binding"];
            }
            set
            { this["Binding"] = value; }
        }
    }
}
