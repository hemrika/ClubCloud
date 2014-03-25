using ClubCloud.Zimbra.Account;
using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    internal partial class ZimbraAccountSoapClient : System.ServiceModel.ClientBase<zimbraAccountSoap>, zimbraAccountSoap
    {

        internal ZimbraAccountSoapClient()
        {
        }

        internal ZimbraAccountSoapClient(ZimbraBinding binding, ZimbraEndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        protected override zimbraAccountSoap CreateChannel()
        {
            return base.CreateChannel();
        }

        public AuthResponse AccountAuth(AuthRequest request)
        {
            return base.Channel.AccountAuth(request);
        }

        public GetInfoResponse GetInfoRequest(GetInfoRequest request)
        {
            return base.Channel.GetInfoRequest(request);
        }

        public GetAccountInfoResponse GetAccountInfoRequest(GetAccountInfoRequest request)
        {
            return base.Channel.GetAccountInfoRequest(request);
        }

        public GetVersionInfoResponse GetVersionInfoRequest(GetVersionInfoRequest request)
        {
            return base.Channel.GetVersionInfoRequest(request);
        }

        public ChangePasswordResponse ChangePasswordRequest(ChangePasswordRequest request)
        {
            return base.Channel.ChangePasswordRequest(request);
        }
    }
}
