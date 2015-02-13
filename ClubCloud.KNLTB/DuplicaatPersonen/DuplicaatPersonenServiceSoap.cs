using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://knltb.nl/services", ConfigurationName = "DuplicaatPersonen.DuplicaatPersonenServiceSoap")]
    public interface DuplicaatPersonenServiceSoap
    {
        [OperationContract(AsyncPattern = true, Action = "http://knltb.nl/services/DuplicaatpersonenFound", ReplyAction = "*")]
        IAsyncResult BeginDuplicaatpersonenFound(DuplicaatpersonenFoundRequest request, AsyncCallback callback, object asyncState);

        [OperationContract(Action = "http://knltb.nl/services/DuplicaatpersonenFound", ReplyAction = "*")]
        [XmlSerializerFormat(SupportFaults = true)]
        DuplicaatpersonenFoundResponse DuplicaatpersonenFound(DuplicaatpersonenFoundRequest request);

        DuplicaatpersonenFoundResponse EndDuplicaatpersonenFound(IAsyncResult result);
    }
}
