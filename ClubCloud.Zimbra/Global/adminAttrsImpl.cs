using ClubCloud.Zimbra.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(updatePresenceSessionIdRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyUCServiceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyServerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(smimeConfigModifications))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyLDAPEntryRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModifyDomainRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyDistributionListRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyDataSourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyCosRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyConfigRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(modifyCalendarResourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModifyAccountRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(networkInformation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(smimeConfigInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetDistributionListRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getDataSourcesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getConfigResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getAllConfigResponse))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(deleteDataSourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createZimletRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(xmppComponentInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(xmppComponentSpec))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createUCServiceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createServerRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ldapEntryInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createLDAPEntryRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createGalSyncAccountRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateDomainRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createDistributionListRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(dataSourceInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(dataSourceSpecifier))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createCosRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(createCalendarResourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(archiveSpec))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateAccountRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(checkRightRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(galContactInfo))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(checkGalConfigRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(checkAuthConfigRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(addGalSyncDataSourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(searchNode))]
    [MessageContract]
    public partial class adminAttrsImpl : ZimbraMessage
    {

        private List<attrN> _a;

        public adminAttrsImpl()
        {
            this._a = new List<attrN>();
        }

        [System.Xml.Serialization.XmlElementAttribute("a")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public List<attrN> a
        {
            get
            {
                return this._a;
            }
            set
            {
                if (((this._a == null)
                            || (_a.Equals(value) != true)))
                {
                    this._a = value;
                    this.OnPropertyChanged("a");
                }
            }
        }
    }
}
