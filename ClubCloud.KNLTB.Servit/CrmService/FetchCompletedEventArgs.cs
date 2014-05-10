using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough]
	public class FetchCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public string Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (string)this.results[0];
			}
		}
		internal FetchCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
