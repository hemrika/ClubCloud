using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0"), EditorBrowsable(EditorBrowsableState.Advanced), DebuggerStepThrough, MessageContract(WrapperName = "ExecuteResponse", WrapperNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", IsWrapped = true)]
	public class ExecuteResponse
	{
		[MessageBodyMember(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices", Order = 0)]
		public Response Response;
		public ExecuteResponse()
		{
		}
		public ExecuteResponse(Response Response)
		{
			this.Response = Response;
		}
	}
}
