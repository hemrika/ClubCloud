using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "RetrieveMultipleResponse", WrapperNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsWrapped = true)]
	public class RetrieveMultipleResponse1
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 0)]
		public BusinessEntityCollection RetrieveMultipleResult;
		public RetrieveMultipleResponse1()
		{
		}
		public RetrieveMultipleResponse1(BusinessEntityCollection RetrieveMultipleResult)
		{
			this.RetrieveMultipleResult = RetrieveMultipleResult;
		}
	}
}
