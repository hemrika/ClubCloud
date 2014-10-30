using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [MessageContract(WrapperName = "DistributionListActionRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public class DistributionListActionRequest : attrsImpl
    {

        private DistributionListSelector _dl;

        private DistributionListAction _action;

        public DistributionListActionRequest()
        {
            this._action = new DistributionListAction();
            this._dl = new DistributionListSelector();
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListSelector dl
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

        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListAction action
        {
            get
            {
                return this._action;
            }
            set
            {
                if (((this._action == null)
                            || (_action.Equals(value) != true)))
                {
                    this._action = value;
                    this.OnPropertyChanged("action");
                }
            }
        }
    }
}
