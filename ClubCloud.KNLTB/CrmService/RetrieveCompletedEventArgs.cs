using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RetrieveCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public BusinessEntity Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (BusinessEntity)this.results[0];
			}
		}

		public RetrieveCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}