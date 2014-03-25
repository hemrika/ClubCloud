using ClubCloud.Zimbra.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    public partial class updatePresenceSessionIdRequest : adminAttrsImpl
    {

        private ucServiceSelector _ucservice;

        private string _username;

        private string _password;

        public updatePresenceSessionIdRequest()
        {
            this._ucservice = new ucServiceSelector();
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ucServiceSelector ucservice
        {
            get
            {
                return this._ucservice;
            }
            set
            {
                if (((this._ucservice == null)
                            || (_ucservice.Equals(value) != true)))
                {
                    this._ucservice = value;
                    this.OnPropertyChanged("ucservice");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username
        {
            get
            {
                return this._username;
            }
            set
            {
                if (((this._username == null)
                            || (_username.Equals(value) != true)))
                {
                    this._username = value;
                    this.OnPropertyChanged("username");
                }
            }
        }

        [System.Xml.Serialization.XmlElementAttribute()]
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string password
        {
            get
            {
                return this._password;
            }
            set
            {
                if (((this._password == null)
                            || (_password.Equals(value) != true)))
                {
                    this._password = value;
                    this.OnPropertyChanged("password");
                }
            }
        }
    }
}
