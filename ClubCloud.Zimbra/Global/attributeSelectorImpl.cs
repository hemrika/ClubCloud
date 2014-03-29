using ClubCloud.Zimbra.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    /*
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(searchDirectoryRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(searchCalendarResourcesRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(searchAutoProvDirectoryRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getZimletRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getXMPPComponentRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getUCServiceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getServerRequest))]
    */
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetDomainRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(GetCosRequest))]
    /*
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getCalendarResourceRequest))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(getAccountRequest))]
    */
    [MessageContract]//(WrapperName = "ModifyDomainRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public abstract partial class attributeSelectorImpl : ZimbraMessage
    {

        private string _attrs;

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string attrs
        {
            get
            {
                return this._attrs;
            }
            set
            {
                if (((this._attrs == null)
                            || (_attrs.Equals(value) != true)))
                {
                    this._attrs = value;
                    this.OnPropertyChanged("attrs");
                }
            }
        }
    }
}
