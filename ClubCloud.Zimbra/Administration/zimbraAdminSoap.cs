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

        [System.ServiceModel.OperationContractAttribute(Name = "ModifyDomainRequest", Action = "AdminModifyDomainResquestMessage", ReplyAction = "AdminModifyDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        ModifyDomainResponse ModifyDomainRequest(ModifyDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetDomainRequest", Action = "AdminGetDomainResquestMessage", ReplyAction = "AdminGetDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetDomainResponse GetDomainRequest(GetDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "CreateDomainRequest", Action = "AdminCreateDomainResquestMessage", ReplyAction = "AdminCreateDomainResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        CreateDomainResponse CreateDomainRequest(CreateDomainRequest request);

        [System.ServiceModel.OperationContractAttribute(Name = "GetCosRequest", Action = "AdminGetCosRequestMessage", ReplyAction = "AdminGetCosResponseMessage")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        GetCosResponse GetCosRequest(GetCosRequest request);
    }
    
}
