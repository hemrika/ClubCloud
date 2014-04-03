using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Service
{
    [Serializable]
    public class ZimbraBindingElement : ConfigurationElement
    {
        public ZimbraBindingElement() { }
        [ConfigurationProperty("AllowCookies", DefaultValue = true, IsRequired = false)]
        public bool AllowCookies
        {
            get
            { return (bool)this["AllowCookies"]; }
            set
            { this["AllowCookies"] = value; }
        }

        [ConfigurationProperty("MaxBufferPoolSize", DefaultValue = "2147483647", IsRequired = false)]
        public long MaxBufferPoolSize
        {
            get
            { return (long)this["MaxBufferPoolSize"]; }
            set
            { this["MaxBufferPoolSize"] = value; }
        }

        [ConfigurationProperty("MaxBufferSize", DefaultValue = "2147483647", IsRequired = false)]
        public int MaxBufferSize
        {
            get
            { return (int)this["MaxBufferSize"]; }
            set
            { this["MaxBufferSize"] = value; }
        }

        [ConfigurationProperty("MaxReceivedMessageSize", DefaultValue = "2147483647", IsRequired = false)]
        public long MaxReceivedMessageSize
        {
            get
            { return (long)this["MaxReceivedMessageSize"]; }
            set
            { this["MaxReceivedMessageSize"] = value; }
        }


        [ConfigurationProperty("MessageEncoding", DefaultValue = WSMessageEncoding.Text, IsRequired = false)]
        public WSMessageEncoding MessageEncoding
        {
            get
            { return (WSMessageEncoding)this["MessageEncoding"]; }
            set
            { this["MessageEncoding"] = value; }
        }

        [ConfigurationProperty("Name", DefaultValue = "ZimbraBinding", IsRequired = false)]
        public string Name
        {
            get
            { return (string)this["Name"]; }
            set
            { this["Name"] = value; }
        }
        /*
        [ConfigurationProperty("OpenTimeout", DefaultValue = 2, IsRequired = false)]
        public TimeSpan OpenTimeout
        {
            get
            { return (TimeSpan)this["OpenTimeout"]; }
            set
            { this["OpenTimeout"] = value; }
        }

        [ConfigurationProperty("ReceiveTimeout", DefaultValue = 2, IsRequired = false)]
        public TimeSpan ReceiveTimeout
        {
            get
            { return (TimeSpan)this["ReceiveTimeout"]; }
            set
            { this["ReceiveTimeout"] = value; }
        }

        [ConfigurationProperty("SendTimeout", DefaultValue = 2, IsRequired = false)]
        public TimeSpan SendTimeout
        {
            get
            { return (TimeSpan)this["SendTimeout"]; }
            set
            { this["SendTimeout"] = value; }
        }
        
        [ConfigurationProperty("TextEncoding", DefaultValue = "UTF8", IsRequired = false)]
        public Encoding TextEncoding
        {
            get
            { return (Encoding)this["TextEncoding"]; }
            set
            { this["TextEncoding"] = value; }
        }
        */

        [ConfigurationProperty("HostNameComparisonMode", DefaultValue = HostNameComparisonMode.WeakWildcard, IsRequired = false)]
        public HostNameComparisonMode HostNameComparisonMode
        {
            get
            { return (HostNameComparisonMode)this["HostNameComparisonMode"]; }
            set
            { this["HostNameComparisonMode"] = value; }
        }
       
    }
}
