using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [MessageContract(WrapperName = "SearchDirectoryRequest", WrapperNamespace = "urn:zimbraAdmin")]
    public partial class SearchDirectoryRequest : attributeSelectorImpl
    {

        private string _query;

        private System.Nullable<int> _maxResults;

        private System.Nullable<int> _limit;

        private System.Nullable<int> _offset;

        private string _domain;

        private System.Nullable<bool> _applyCos;

        private System.Nullable<bool> _applyConfig;

        private string _sortBy;

        private string _types;

        private System.Nullable<bool> _sortAscending;

        private System.Nullable<bool> _countOnly;

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string query
        {
            get
            {
                return this._query;
            }
            set
            {
                if (((this._query == null)
                            || (_query.Equals(value) != true)))
                {
                    this._query = value;
                    this.OnPropertyChanged("query");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public int maxResults
        {
            get
            {
                if (this._maxResults.HasValue)
                {
                    return this._maxResults.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_maxResults.Equals(value) != true))
                {
                    this._maxResults = value;
                    this.OnPropertyChanged("maxResults");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public int limit
        {
            get
            {
                if (this._limit.HasValue)
                {
                    return this._limit.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_limit.Equals(value) != true))
                {
                    this._limit = value;
                    this.OnPropertyChanged("limit");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public int offset
        {
            get
            {
                if (this._offset.HasValue)
                {
                    return this._offset.Value;
                }
                else
                {
                    return default(int);
                }
            }
            set
            {
                if ((_offset.Equals(value) != true))
                {
                    this._offset = value;
                    this.OnPropertyChanged("offset");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string domain
        {
            get
            {
                return this._domain;
            }
            set
            {
                if (((this._domain == null)
                            || (_domain.Equals(value) != true)))
                {
                    this._domain = value;
                    this.OnPropertyChanged("domain");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool applyCos
        {
            get
            {
                if (this._applyCos.HasValue)
                {
                    return this._applyCos.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_applyCos.Equals(value) != true))
                {
                    this._applyCos = value;
                    this.OnPropertyChanged("applyCos");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool applyConfig
        {
            get
            {
                if (this._applyConfig.HasValue)
                {
                    return this._applyConfig.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_applyConfig.Equals(value) != true))
                {
                    this._applyConfig = value;
                    this.OnPropertyChanged("applyConfig");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string sortBy
        {
            get
            {
                return this._sortBy;
            }
            set
            {
                if (((this._sortBy == null)
                            || (_sortBy.Equals(value) != true)))
                {
                    this._sortBy = value;
                    this.OnPropertyChanged("sortBy");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public string types
        {
            get
            {
                return this._types;
            }
            set
            {
                if (((this._types == null)
                            || (_types.Equals(value) != true)))
                {
                    this._types = value;
                    this.OnPropertyChanged("types");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool sortAscending
        {
            get
            {
                if (this._sortAscending.HasValue)
                {
                    return this._sortAscending.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_sortAscending.Equals(value) != true))
                {
                    this._sortAscending = value;
                    this.OnPropertyChanged("sortAscending");
                }
            }
        }

        //[System.Xml.Serialization.XmlAttributeAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        [MessageBodyMember]
        public bool countOnly
        {
            get
            {
                if (this._countOnly.HasValue)
                {
                    return this._countOnly.Value;
                }
                else
                {
                    return default(bool);
                }
            }
            set
            {
                if ((_countOnly.Equals(value) != true))
                {
                    this._countOnly = value;
                    this.OnPropertyChanged("countOnly");
                }
            }
        }
    }
}
