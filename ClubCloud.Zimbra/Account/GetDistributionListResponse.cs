//using ClubCloud.Zimbra.Global;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.ServiceModel;
//using System.Text;
//using System.Threading.Tasks;

//namespace ClubCloud.Zimbra.Account
//{
//    [MessageContract(WrapperName = "GetDistributionListResponse", WrapperNamespace = "urn:zimbraAccount")]
//    public partial class GetDistributionListResponse : ZimbraMessage
//    {

//        private DistributionListInfo _dl;

//        public GetDistributionListResponse()
//        {
//            this._dl = new DistributionListInfo();
//        }

//        [System.Xml.Serialization.XmlElementAttribute()]
//        [System.Runtime.Serialization.DataMemberAttribute()]
//        [MessageBodyMember]
//        public DistributionListInfo dl
//        {
//            get
//            {
//                return this._dl;
//            }
//            set
//            {
//                if (((this._dl == null)
//                            || (_dl.Equals(value) != true)))
//                {
//                    this._dl = value;
//                    this.OnPropertyChanged("dl");
//                }
//            }
//        }
//    }
//}
