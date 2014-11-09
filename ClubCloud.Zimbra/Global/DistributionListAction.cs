using ClubCloud.Zimbra.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Global
{
    public partial class DistributionListAction : AccountKeyValuePairs
    {

        private List<string> _dlm;

        private string _newName;

        private List<DistributionListGranteeSelector> _owner;

        private List<DistributionListRightSpec> _right;

        private DistributionListSubscribeReq _subsReq;

        private Operation _op;

        public DistributionListAction()
        {
            this._subsReq = new DistributionListSubscribeReq();
            this._right = new List<DistributionListRightSpec>();
            this._owner = new List<DistributionListGranteeSelector>();
            this._dlm = new List<string>();
        }

        //[System.Xml.Serialization.XmlElementAttribute("dlm")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<string> dlm
        {
            get
            {
                return this._dlm;
            }
            set
            {
                if (((this._dlm == null)
                            || (_dlm.Equals(value) != true)))
                {
                    this._dlm = value;
                    this.OnPropertyChanged("dlm");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string newName
        {
            get
            {
                return this._newName;
            }
            set
            {
                if (((this._newName == null)
                            || (_newName.Equals(value) != true)))
                {
                    this._newName = value;
                    this.OnPropertyChanged("newName");
                }
            }
        }

        //[System.Xml.Serialization.XmlElementAttribute("owner")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DistributionListGranteeSelector> owner
        {
            get
            {
                return this._owner;
            }
            set
            {
                if (((this._owner == null)
                            || (_owner.Equals(value) != true)))
                {
                    this._owner = value;
                    this.OnPropertyChanged("owner");
                }
            }
        }

        //[System.Xml.Serialization.XmlElementAttribute("right")]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public List<DistributionListRightSpec> right
        {
            get
            {
                return this._right;
            }
            set
            {
                if (((this._right == null)
                            || (_right.Equals(value) != true)))
                {
                    this._right = value;
                    this.OnPropertyChanged("right");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public DistributionListSubscribeReq subsReq
        {
            get
            {
                return this._subsReq;
            }
            set
            {
                if (((this._subsReq == null)
                            || (_subsReq.Equals(value) != true)))
                {
                    this._subsReq = value;
                    this.OnPropertyChanged("subsReq");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public Operation op
        {
            get
            {
                return this._op;
            }
            set
            {
                if ((_op.Equals(value) != true))
                {
                    this._op = value;
                    this.OnPropertyChanged("op");
                }
            }
        }
    }
}
