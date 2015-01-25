using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class ExecuteCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public Response Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (Response)this.results[0];
			}
		}

		public ExecuteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}