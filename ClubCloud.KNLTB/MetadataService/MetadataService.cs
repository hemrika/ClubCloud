using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "MetadataServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlInclude(typeof(CrmNullable))]
	public class MetadataService : SoapHttpClientProtocol
	{
		private CrmAuthenticationToken crmAuthenticationTokenValueField;
		private CallerOriginToken callerOriginTokenValueField;
		private SendOrPostCallback ExecuteOperationCompleted;
		private bool useDefaultCredentialsSetExplicitly;
		public event ExecuteCompletedEventHandler ExecuteCompleted;
		public CrmAuthenticationToken CrmAuthenticationTokenValue
		{
			get
			{
				return this.crmAuthenticationTokenValueField;
			}
			set
			{
				this.crmAuthenticationTokenValueField = value;
			}
		}
		public CallerOriginToken CallerOriginTokenValue
		{
			get
			{
				return this.callerOriginTokenValueField;
			}
			set
			{
				this.callerOriginTokenValueField = value;
			}
		}
		public new string Url
		{
			get
			{
				return base.Url;
			}
			set
			{
				if (this.IsLocalFileSystemWebService(base.Url) && !this.useDefaultCredentialsSetExplicitly && !this.IsLocalFileSystemWebService(value))
				{
					base.UseDefaultCredentials = false;
				}
				base.Url = value;
			}
		}
		public new bool UseDefaultCredentials
		{
			get
			{
				return base.UseDefaultCredentials;
			}
			set
			{
				base.UseDefaultCredentials = value;
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		public MetadataService()
		{
			this.Url = "https://servit.mijnknltb.nl/mscrmservices/2007/metadataservice.asmx";
			if (this.IsLocalFileSystemWebService(this.Url))
			{
				this.UseDefaultCredentials = true;
				this.useDefaultCredentialsSetExplicitly = false;
			}
			else
			{
				this.useDefaultCredentialsSetExplicitly = true;
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Execute", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CrmAuthenticationTokenValue"), SoapHeader("CallerOriginTokenValue")]
		[return: XmlElement("Response")]
		public MetadataServiceResponse Execute(MetadataServiceRequest Request)
		{
			object[] results = base.Invoke("Execute", new object[]
			{
				Request
			});
			return (MetadataServiceResponse)results[0];
		}
		public void ExecuteAsync(MetadataServiceRequest Request)
		{
			this.ExecuteAsync(Request, null);
		}
		public void ExecuteAsync(MetadataServiceRequest Request, object userState)
		{
			if (this.ExecuteOperationCompleted == null)
			{
				this.ExecuteOperationCompleted = new SendOrPostCallback(this.OnExecuteOperationCompleted);
			}
			base.InvokeAsync("Execute", new object[]
			{
				Request
			}, this.ExecuteOperationCompleted, userState);
		}
		private void OnExecuteOperationCompleted(object arg)
		{
			if (this.ExecuteCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.ExecuteCompleted(this, new ExecuteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		public new void CancelAsync(object userState)
		{
			base.CancelAsync(userState);
		}
		private bool IsLocalFileSystemWebService(string url)
		{
			bool result;
			if (url == null || url == string.Empty)
			{
				result = false;
			}
			else
			{
				Uri wsUri = new Uri(url);
				result = (wsUri.Port >= 1024 && string.Compare(wsUri.Host, "localHost", StringComparison.OrdinalIgnoreCase) == 0);
			}
			return result;
		}
	}
}
