using ClubCloud.KNLTB.Servit.CRM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Servit
{
    public class ServItService : System.ComponentModel.INotifyPropertyChanged, IDisposable
    {
        //private static ServItBinding binding = new ServItBinding();

        //private static ServItEndpointAddress remoteAddress { get; set; }

        //private static string _serverNameClient;

        private static ServItSoapClient client = null;

        private CookieContainer _CookieContainer;
        private static string ServItUrl = "https://servit.mijnknltb.nl/MSCrmServices/2007/CrmService.asmx";

        public CookieContainer CookieContainer
        {
            get { return _CookieContainer; }
            set { _CookieContainer = value; }
        }

        /*
        public static string ServerNameClient
        {
            get { return ServItService._serverNameClient; }
            set { ServItService._serverNameClient = value; }
        }
        */

        public ServItService(string username, string password)
        {
            KNLTB.Security.KNLTBContainer container = new Security.KNLTBContainer();
            container.RequestAcces(username, password);
            while (container.Container == null) { }
            CookieContainer = container.Container;

            Connect();

        }

        private void Connect()
        {
            client = new ServItSoapClient();
            client.Url = ServItUrl;
            client.CookieContainer = CookieContainer;

            CrmAuthenticationToken crmAuthenticationToken = new CrmAuthenticationToken();
            crmAuthenticationToken.AuthenticationType = 0;
            crmAuthenticationToken.CrmTicket = string.Empty;
            crmAuthenticationToken.OrganizationName = "KNLTB";
            crmAuthenticationToken.CallerId = new Guid("00000000-0000-0000-0000-000000000000");

            client.CrmAuthenticationTokenValue = crmAuthenticationToken;


        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            if (client != null)
            {
                client.Dispose();
                client = null;
            }
        }
    }
}
