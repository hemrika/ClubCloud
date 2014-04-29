using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace ClubCloud.Provider
{
    [Guid("B0FB9FD3-F138-49CA-A928-5209253D3036")]
    public class ZimbraUserSettingsProvider : SPUserSettingsProvider
    {
        public ZimbraUserSettingsProvider() : base()
        { }


        protected override bool FillIsUserSettingsInitialized(object providerContext, Microsoft.SharePoint.SPUser user, out bool isUserSettingsInitialized)
        {
            throw new NotImplementedException();
        }

        protected override bool FillIsUserSettingsPropertyEditable(object providerContext, Microsoft.SharePoint.SPUser user, SPUserSettingsProperty usProperty, out bool isUserEditable)
        {
            isUserEditable = true;
            return isUserEditable;
            //throw new NotImplementedException();
        }

        protected override bool FillProviderContext(Microsoft.SharePoint.SPUser user, out object providerContext)
        {
            object context = null;
            foreach (SPUserSettingsProvider provider in SPUserSettingsProviderManager.Local.UserSettingsProviders)
            {
                try
                {
                    if (this.Name == provider.Name)
                    {
                        context = Provider;
                    }
                }
                catch { };
            }
            providerContext = context;
            return (providerContext != null);
        }

        protected override bool FillUserSettingsEditorUri(object providerContext, Microsoft.SharePoint.SPUser user, string source, out string userSettingsEditorUri)
        {
            userSettingsEditorUri = null;
            return false;
            //throw new NotImplementedException();
        }

        protected override bool FillUserSettingsPropertyValue(object providerContext, Microsoft.SharePoint.SPUser user, SPUserSettingsProperty usProperty, out object value)
        {
            value = null;
            return false;
            //throw new NotImplementedException();
        }

        public override bool IsValid()
        {
            return true;
        }

        public override string Name
        {
            get { return "ZimbraUserSettings"; }
        }

        protected override bool UpdateUserSettingsProperties(object providerContext, Microsoft.SharePoint.SPUser user, SPUserSettingsProperty[] usProperty, object[] values)
        {
            return false;
            //throw new NotImplementedException();
        }

        private string m_providerName = "ZimbraMembershipProvider";

        public string ProviderName
        {
            get
            {
                return this.m_providerName;
            }
        }

        private MembershipProvider m_membershipProvider;
        public MembershipProvider Provider
        {
            get
            {
                if (this.m_membershipProvider == null)
                {
                    this.m_membershipProvider = Membership.Providers[this.ProviderName];
                }
                return this.m_membershipProvider;
            }
        }
    }
}
