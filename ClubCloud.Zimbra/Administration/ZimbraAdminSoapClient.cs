using ClubCloud.Zimbra.Global;
using ClubCloud.Zimbra.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    internal partial class ZimbraAdminSoapClient : System.ServiceModel.ClientBase<zimbraAdminSoap>, zimbraAdminSoap
    {

        internal ZimbraAdminSoapClient()
        {
        }

        internal ZimbraAdminSoapClient(ZimbraBinding binding, ZimbraEndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        protected override zimbraAdminSoap CreateChannel()
        {
            return base.CreateChannel();
        }

        public AuthResponse AccountAuth(AuthRequest request)
        {
            return base.Channel.AccountAuth(request);
        }

        public GetVersionInfoResponse GetVersionInfoRequest(GetVersionInfoRequest request)
        {
            return base.Channel.GetVersionInfoRequest(request);
        }

        public GetAllDomainsResponse GetAllDomainsRequest(GetAllDomainsRequest request)
        {
            return base.Channel.GetAllDomainsRequest(request);
        }

        public GetAccountInfoResponse GetAccountInfoRequest(GetAccountInfoRequest request)
        {
            return base.Channel.GetAccountInfoRequest(request);
        }

        public GetAccountResponse GetAccountRequest(GetAccountRequest request)
        {
            try
            {
                return base.Channel.GetAccountRequest(request);
            }
            catch { return null; }
            
        }

        public ModifyDomainResponse ModifyDomainRequest(ModifyDomainRequest request)
        {
            return base.Channel.ModifyDomainRequest(request);
        }
        public ModifyAccountResponse ModifyAccountRequest(ModifyAccountRequest request)
        {
            return base.Channel.ModifyAccountRequest(request);
        }
        public GetDomainResponse GetDomainRequest(GetDomainRequest request)
        {
            return base.Channel.GetDomainRequest(request);
        }

        public CreateDomainResponse CreateDomainRequest(CreateDomainRequest request)
        {
            return base.Channel.CreateDomainRequest(request);
        }

        public CreateAccountResponse CreateAccountRequest(CreateAccountRequest request)
        {
            return base.Channel.CreateAccountRequest(request);
        }

        public GetCosResponse GetCosRequest(GetCosRequest request)
        {
            return base.Channel.GetCosRequest(request);
        }

        public GetAllDistributionListsResponse GetAllDistributionListsRequest(GetAllDistributionListsRequest request)
        {
            return base.Channel.GetAllDistributionListsRequest(request);
        }

        public GetAccountMembershipResponse GetAccountMembershipRequest(GetAccountMembershipRequest request)
        {
            return base.Channel.GetAccountMembershipRequest(request);
        }

        public GetDistributionListResponse GetDistributionListRequest(GetDistributionListRequest request)
        {
            return base.Channel.GetDistributionListRequest(request);
        }

        public CreateDistributionListResponse CreateDistributionListRequest(CreateDistributionListRequest request) 
        {
            return base.Channel.CreateDistributionListRequest(request);
        }

        public RemoveDistributionListMemberResponse RemoveDistributionListMemberRequest(RemoveDistributionListMemberRequest request)
        {
            return base.Channel.RemoveDistributionListMemberRequest(request);
        }

        public AddDistributionListMemberResponse AddDistributionListMemberRequest(AddDistributionListMemberRequest request) 
        {
            return base.Channel.AddDistributionListMemberRequest(request);
        }

        public SearchDirectoryResponse SearchDirectoryRequest(SearchDirectoryRequest request)
        {
            try
            {
                return base.Channel.SearchDirectoryRequest(request);
            }
            catch { return null; }
        }

        public GetAllAccountsResponse GetAllAccountsRequest(GetAllAccountsRequest request)
        {
            return base.Channel.GetAllAccountsRequest(request);
        }

        public SetPasswordResponse SetPasswordRequest(SetPasswordRequest request)
        {
            return base.Channel.SetPasswordRequest(request);
        }
    }
}
