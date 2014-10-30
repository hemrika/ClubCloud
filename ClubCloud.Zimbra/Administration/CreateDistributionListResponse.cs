using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "CreateDistributionListResponse", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class CreateDistributionListResponse : ZimbraMessage
    {

        private DistributionListInfo _dl;

        public CreateDistributionListResponse()
        {
            this._dl = new DistributionListInfo();
        }

        //[System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListInfo dl
        {
            get
            {
                return this._dl;
            }
            set
            {
                if (((this._dl == null)
                            || (_dl.Equals(value) != true)))
                {
                    this._dl = value;
                    this.OnPropertyChanged("dl");
                }
            }
        }
    }
}
