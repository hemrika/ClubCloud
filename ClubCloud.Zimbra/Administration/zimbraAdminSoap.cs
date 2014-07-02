using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Administration
{
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:zimbraAdmin", Name = "zimbraAdmin")]
    internal interface zimbraAdminSoap
    {
        [System.ServiceModel.OperationContractAttribute(Name = "AuthRequest", Action = "AdminAuthRequestMessage", ReplyAction = "AdminAuthResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        AuthResponse AccountAuth(AuthRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetVersionInfoRequest", Action = "AdminGetVersionInfoRequestMessage", ReplyAction = "AdminGetVersionInfoResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetVersionInfoResponse GetVersionInfoRequest(GetVersionInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAllDomainsResquest", Action = "AdminGetAllDomainsResquestMessage", ReplyAction = "AdminGetAllDomainsResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAllDomainsResponse GetAllDomainsRequest(GetAllDomainsRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAccountInfoRequest", Action = "AccountGetAccountInfoRequestMessage", ReplyAction = "AccountGetAccountInfoResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAccountInfoResponse GetAccountInfoRequest(GetAccountInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAccountRequest", Action = "AccountGetAccountRequestMessage", ReplyAction = "AccountGetAccountResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAccountResponse GetAccountRequest(GetAccountRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "ModifyDomainRequest", Action = "AdminModifyDomainResquestMessage", ReplyAction = "AdminModifyDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        ModifyDomainResponse ModifyDomainRequest(ModifyDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "ModifyAccountRequest", Action = "AdminModifyAccountRequestMessage", ReplyAction = "AdminModifyAccountResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        ModifyAccountResponse ModifyAccountRequest(ModifyAccountRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetDomainRequest", Action = "AdminGetDomainResquestMessage", ReplyAction = "AdminGetDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetDomainResponse GetDomainRequest(GetDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "CreateDomainRequest", Action = "AdminCreateDomainResquestMessage", ReplyAction = "AdminCreateDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        CreateDomainResponse CreateDomainRequest(CreateDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "CreateAccountRequest", Action = "AdminCreateAccountRequestMessage", ReplyAction = "AdminCreateAccountResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        CreateAccountResponse CreateAccountRequest(CreateAccountRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetCosRequest", Action = "AdminGetCosRequestMessage", ReplyAction = "AdminGetCosResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetCosResponse GetCosRequest(GetCosRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAllDistributionListsRequest", Action = "AdminGetAllDistributionListsRequest", ReplyAction = "AdminGetAllDistributionListsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAllDistributionListsResponse GetAllDistributionListsRequest(GetAllDistributionListsRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAccountMembershipRequest", Action = "AdminGetAccountMembershipRequest", ReplyAction = "AdminGetAccountMembershipResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAccountMembershipResponse GetAccountMembershipRequest(GetAccountMembershipRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetDistributionListRequest", Action = "AdminGetDistributionListRequest", ReplyAction = "AdminGetDistributionListResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetDistributionListResponse GetDistributionListRequest(GetDistributionListRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "SearchDirectoryRequest", Action = "AdminSearchDirectoryRequest", ReplyAction = "AdminSearchDirectoryResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        SearchDirectoryResponse SearchDirectoryRequest(SearchDirectoryRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAllAccountsRequest", Action = "AdminGetAllAccountsRequest", ReplyAction = "AdminGetAllAccountsResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAllAccountsResponse GetAllAccountsRequest(GetAllAccountsRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "SetPasswordRequest", Action = "AdminSetPasswordRequest", ReplyAction = "AdminSetPasswordResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        SetPasswordResponse SetPasswordRequest(SetPasswordRequest request);
        
    }
    
}
