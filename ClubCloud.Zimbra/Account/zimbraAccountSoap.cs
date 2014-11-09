using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.Zimbra.Account
{
    [System.ServiceModel.ServiceContractAttribute(Namespace = "urn:zimbraAccount", Name = "zimbraAccount")]
    internal interface zimbraAccountSoap
    {
        
        [System.ServiceModel.OperationContractAttribute(Name = "AuthRequest", Action = "AccountAuthRequestMessage", ReplyAction = "AccountAuthResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        AuthResponse AccountAuth(AuthRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetInfoRequest", Action = "AccountGetInfoRequestMessage", ReplyAction = "AccountGetInfoResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetInfoResponse GetInfoRequest(GetInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetAccountInfoRequest", Action = "AccountGetAccountInfoRequestMessage", ReplyAction = "AccountGetAccountInfoResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetAccountInfoResponse GetAccountInfoRequest(GetAccountInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetVersionInfoRequest", Action = "AccountGetVersionInfoRequestMessage", ReplyAction = "AccountGetVersionInfoResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetVersionInfoResponse GetVersionInfoRequest(GetVersionInfoRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "ChangePasswordRequest", Action = "AccountChangePasswordRequestMessage", ReplyAction = "AccountChangePasswordResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        ChangePasswordResponse ChangePasswordRequest(ChangePasswordRequest request);

        /*
        [System.ServiceModel.OperationContractAttribute(Name = "GetDistributionListRequest", Action = "AccountGetDistributionListRequest", ReplyAction = "AccountGetDistributionListResponse")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetDistributionListResponse GetDistributionListRequest(GetDistributionListRequest request);
        */

        [System.ServiceModel.OperationContractAttribute(Name = "DistributionListActionRequest", Action = "AccountDistributionListActionRequestMessage", ReplyAction = "AccountDistributionListActionResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        DistributionListActionResponse DistributionListActionRequest(DistributionListActionRequest request);
    }
    
}
