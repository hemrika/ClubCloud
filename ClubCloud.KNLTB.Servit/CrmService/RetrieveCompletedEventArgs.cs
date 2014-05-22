using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough]
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
		internal RetrieveCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}