using System;
using System.Collections.Generic;
using System.Configuration;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace ClubCloud.Zimbra.Service
{
    public class ZimbraConfigurationSection : ConfigurationSection
    {
        [ConfigurationProperty("Server")]
        public ZimbraServerElement Server
        {
            get
            {
                //ProtectSection();
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
                //ProtectSection();
                return (ZimbraBindingElement)this["Binding"];
            }
            set
            { this["Binding"] = value; }
        }

        public void ProtectSection()
        {
            if (!this.SectionInformation.IsProtected)
            {
                this.SectionInformation.ProtectSection("DataProtectionConfigurationProvider");
                this.CurrentConfiguration.Save();
            }
        }
        private void UnProtectSection(string sectionName)
        {
            if (this.SectionInformation.IsProtected)
            {
                this.SectionInformation.UnprotectSection();
                this.CurrentConfiguration.Save();
            }
        }
    }
}
