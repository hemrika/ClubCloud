using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Service
{
    [Serializable]
    public class ZimbraServerElement : ConfigurationElement
    {
        public ZimbraServerElement() {}
        [ConfigurationProperty("Name", IsRequired = false)]
        public string Name
        {
            get
            { return (string)this["Name"]; }
            set
            { this["Name"] = value; }
        }

        [ConfigurationProperty("ServerName", IsRequired = false)]
        public string ServerName
        {
            get
            { return (string)this["ServerName"]; }
            set
            { this["ServerName"] = value; }
        }
        [ConfigurationProperty("UserName", IsRequired = false)]
        public string UserName
        {
            get
            { return (string)this["UserName"]; }
            set
            { this["UserName"] = value; }
        }

        [ConfigurationProperty("Password", IsRequired = false)]
        public string Password
        {
            get
            { return (string)this["Password"]; }
            set
            { this["Password"] = value; }
        }

        [ConfigurationProperty("Encoded", DefaultValue = false, IsRequired = false)]
        public bool Encoded
        {
            get
            { return (bool)this["Encoded"]; }
            set
            { this["Encoded"] = value; }
        }

        [ConfigurationProperty("IsAdmin", DefaultValue = true, IsRequired = false)]
        public bool IsAdmin
        {
            get
            { return (bool)this["IsAdmin"]; }
            set
            { this["IsAdmin"] = value; }
        }

        [ConfigurationProperty("ClassOfService", DefaultValue = "clubcloud", IsRequired = false)]
        public string ClassOfService
        {
            get
            { return (string)this["ClassOfService"]; }
            set
            { this["ClassOfService"] = value; }
        }
    }
}
