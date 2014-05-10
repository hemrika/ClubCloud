using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough]
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
		internal ExecuteCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
