using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	public class RetrieveMultipleCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;

		public BusinessEntityCollection Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (BusinessEntityCollection)this.results[0];
			}
		}

		public RetrieveMultipleCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}