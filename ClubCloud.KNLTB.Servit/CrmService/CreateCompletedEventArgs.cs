using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough]
	public class CreateCompletedEventArgs : AsyncCompletedEventArgs
	{
		private object[] results;
		public Guid Result
		{
			get
			{
				base.RaiseExceptionIfNecessary();
				return (Guid)this.results[0];
			}
		}
		internal CreateCompletedEventArgs(object[] results, Exception exception, bool cancelled, object userState) : base(exception, cancelled, userState)
		{
			this.results = results;
		}
	}
}
