using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "DuplicaatPersonenServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlInclude(typeof(OrganizationHeader))]
    public class DuplicaatPersonenService : SoapHttpClientProtocol
    {
        private bool useDefaultCredentialsSetExplicitly;
        private OrganizationHeader _organizationHeader;
        //private SendOrPostCallback DuplicaatPersonenOperationCompleted;
        //public event DuplicaatpersonenFoundCompletedEventArgs DuplicaatPersonenCompleted;

        public OrganizationHeader OrganizationHeader
        {
            get { return _organizationHeader; }
            set { _organizationHeader = value; }
        }

        public CookieContainer ServiceCookieContainer
        {
            get
            {
                return this.CookieContainer;
            }
            set
            {
                this.CookieContainer = value;
            }
        }

        /// <summary>
        /// https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/DuplicaatDetectiePersonen/DuplicaatPersonen.asmx
        /// </summary>
        public DuplicaatPersonenService()
		{
            this.Url = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/DuplicaatDetectiePersonen/DuplicaatPersonen.asmx";

			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}

            this.OrganizationHeader = new OrganizationHeader { OrganizationName = "KNLTB", ServerUrl = "https://servit.mijnknltb.nl/" };

		}

        /// <summary>
        /// https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/DuplicaatDetectiePersonen/DuplicaatPersonen.asmx
        /// </summary>
        public DuplicaatPersonenService(System.Net.CookieContainer cc)
        {
            this.Url = "https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Ledenadministratie/OnderhoudenPersonen/DuplicaatDetectiePersonen/DuplicaatPersonen.asmx";

            if (this.IsLocalFileSystemWebService(this.Url))
            {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else
            {
                this.useDefaultCredentialsSetExplicitly = true;
            }

            this.OrganizationHeader = new OrganizationHeader { OrganizationName = "KNLTB", ServerUrl = "https://servit.mijnknltb.nl/" };
            this.ServiceCookieContainer = cc;
        }

        public new string Url
        {
            get
            {
                return base.Url;
            }
            set
            {
                if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
                {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        public new bool UseDefaultCredentials
        {
            get
            {
                return base.UseDefaultCredentials;
            }
            set
            {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }

        private bool IsLocalFileSystemWebService(string url)
        {
            bool result;
            if (url == null || url == string.Empty)
            {
                result = false;
            }
            else
            {
                Uri wsUri = new Uri(url);
                result = (wsUri.Port >= 1024 && string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0);
            }
            return result;
        }
    }
}
