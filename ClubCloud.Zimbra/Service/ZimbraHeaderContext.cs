namespace ClubCloud.Zimbra.Service
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using ClubCloud.Zimbra.Global;

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "urn:zimbra")]
    [System.Xml.Serialization.XmlRootAttribute("context", Namespace = "urn:zimbra",ElementName="context")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "context", Namespace = "urn:zimbra")]
    internal partial class ZimbraHeaderContext //: ZimbraMessage
    {

        private string _authToken;

        private authTokenControl _authTokenControl;

        private string _sessionId;

        private string _account;
        //private accountSelector _account;

        //private string _change;
        private change _change;

        private string _targetServer;

        //private string _userAgent;
        private userAgent _userAgent;
        public ZimbraHeaderContext()
        {

        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "authToken", IsRequired = false)]
        public string authToken
        {
            get
            {
                return this._authToken;
            }
            set
            {
                if (((this._authToken == null)
                            || (_authToken.Equals(value) != true)))
                {
                    this._authToken = value;
                    //this.OnPropertyChanged("authToken");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "authTokenControl", IsRequired = false)]
        public authTokenControl AuthTokenControl
        {
            get { return _authTokenControl; }
            set
            {
                if (((this._authTokenControl == null)
                    || (_authTokenControl.Equals(value) != true)))
                {
                    this._authTokenControl = value;
                    //this.OnPropertyChanged("authTokenControl");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "sessionId", IsRequired = false)]
        public string sessionId
        {
            get
            {
                return this._sessionId;
            }
            set
            {
                if (((this._sessionId == null)
                            || (_sessionId.Equals(value) != true)))
                {
                    this._sessionId = value;
                    //this.OnPropertyChanged("sessionId");
                }
            }
        }

        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "account", IsRequired = false)]
        public string account
        {
            get
            {
                return this._account;
            }
            set
            {
                if (((this._account == null)
                            || (_account.Equals(value) != true)))
                {
                    this._account = value;
                    //this.OnPropertyChanged("account");
                }
            }
        }
        
        /*
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired = false, Name= "account", EmitDefaultValue = false)]
        public accountSelector account
        {
            get
            {
                return this._account;
            }
            set
            {
                if (((this._account == null)
                            || (_account.Equals(value) != true)))
                {
                    this._account = value;
                    //this.OnPropertyChanged("account");
                }
            }
        }
        */

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "change", IsRequired = false)]
        public change change
        {
            get
            {
                return this._change;
            }
            set
            {
                if (((this._change == null)
                            || (_change.Equals(value) != true)))
                {
                    this._change = value;
                    //this.OnPropertyChanged("change");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "targetServer", IsRequired = false)]
        public string targetServer
        {
            get
            {
                return this._targetServer;
            }
            set
            {
                if (((this._targetServer == null)
                            || (_targetServer.Equals(value) != true)))
                {
                    this._targetServer = value;
                    //this.OnPropertyChanged("targetServer");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue = false, Name = "userAgent", IsRequired = false)]
        public userAgent userAgent
        {
            get
            {
                return this._userAgent;
            }
            set
            {
                if (((this._userAgent == null)
                            || (_userAgent.Equals(value) != true)))
                {
                    this._userAgent = value;
                    //this.OnPropertyChanged("userAgent");
                }
            }
        }

    }
}

