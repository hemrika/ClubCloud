using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Web.Services", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, WebServiceBinding(Name = "CrmServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices"), XmlInclude(typeof(CrmReference)), XmlInclude(typeof(Property[])), XmlInclude(typeof(activityparty[]))]
	public class CrmService : SoapHttpClientProtocol
	{
		private CrmAuthenticationToken crmAuthenticationTokenValueField;
		private CallerOriginToken callerOriginTokenValueField;
		private CorrelationToken correlationTokenValueField;
		private SendOrPostCallback ExecuteOperationCompleted;
		private SendOrPostCallback FetchOperationCompleted;
		private SendOrPostCallback CreateOperationCompleted;
		private SendOrPostCallback DeleteOperationCompleted;
		private SendOrPostCallback RetrieveOperationCompleted;
		private SendOrPostCallback RetrieveMultipleOperationCompleted;
		private SendOrPostCallback UpdateOperationCompleted;
		private bool useDefaultCredentialsSetExplicitly;
		public event ExecuteCompletedEventHandler ExecuteCompleted;
		public event FetchCompletedEventHandler FetchCompleted;
		public event CreateCompletedEventHandler CreateCompleted;
		public event DeleteCompletedEventHandler DeleteCompleted;
		public event RetrieveCompletedEventHandler RetrieveCompleted;
		public event RetrieveMultipleCompletedEventHandler RetrieveMultipleCompleted;
		public event UpdateCompletedEventHandler UpdateCompleted;
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
		public CorrelationToken CorrelationTokenValue
		{
			get
			{
				return this.correlationTokenValueField;
			}
			set
			{
				this.correlationTokenValueField = value;
			}
		}

        public CookieContainer CrmCookieContainer
        {
            get
            {
                return this.CookieContainer;
            }
            set
            {
                this.CookieContainer = value;
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
		public CrmService()
		{
			this.Url = "https://servit.mijnknltb.nl/MSCrmServices/2007/CrmService.asmx";
            //this.Url = "https://servit.mijnknltb.nl/KNLTB/MSCrmServices/2007/CrmService.asmx";
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
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Execute", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CorrelationTokenValue"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		[return: XmlElement("Response")]
		public Response Execute(Request Request)
		{
			object[] results = base.Invoke("Execute", new object[]
			{
				Request
			});
			return (Response)results[0];
		}
		public void ExecuteAsync(Request Request)
		{
			this.ExecuteAsync(Request, null);
		}
		public void ExecuteAsync(Request Request, object userState)
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
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Fetch", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		public string Fetch(string fetchXml)
		{
			object[] results = base.Invoke("Fetch", new object[]
			{
				fetchXml
			});
			return (string)results[0];
		}
		public void FetchAsync(string fetchXml)
		{
			this.FetchAsync(fetchXml, null);
		}
		public void FetchAsync(string fetchXml, object userState)
		{
			if (this.FetchOperationCompleted == null)
			{
				this.FetchOperationCompleted = new SendOrPostCallback(this.OnFetchOperationCompleted);
			}
			base.InvokeAsync("Fetch", new object[]
			{
				fetchXml
			}, this.FetchOperationCompleted, userState);
		}
		private void OnFetchOperationCompleted(object arg)
		{
			if (this.FetchCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.FetchCompleted(this, new FetchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Create", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CorrelationTokenValue"), SoapHeader("CallerOriginTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		public Guid Create(BusinessEntity entity)
		{
			object[] results = base.Invoke("Create", new object[]
			{
				entity
			});
			return (Guid)results[0];
		}
		public void CreateAsync(BusinessEntity entity)
		{
			this.CreateAsync(entity, null);
		}
		public void CreateAsync(BusinessEntity entity, object userState)
		{
			if (this.CreateOperationCompleted == null)
			{
				this.CreateOperationCompleted = new SendOrPostCallback(this.OnCreateOperationCompleted);
			}
			base.InvokeAsync("Create", new object[]
			{
				entity
			}, this.CreateOperationCompleted, userState);
		}
		private void OnCreateOperationCompleted(object arg)
		{
			if (this.CreateCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.CreateCompleted(this, new CreateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Delete", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CrmAuthenticationTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CallerOriginTokenValue")]
		public void Delete(string entityName, Guid id)
		{
			base.Invoke("Delete", new object[]
			{
				entityName,
				id
			});
		}
		public void DeleteAsync(string entityName, Guid id)
		{
			this.DeleteAsync(entityName, id, null);
		}
		public void DeleteAsync(string entityName, Guid id, object userState)
		{
			if (this.DeleteOperationCompleted == null)
			{
				this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
			}
			base.InvokeAsync("Delete", new object[]
			{
				entityName,
				id
			}, this.DeleteOperationCompleted, userState);
		}
		private void OnDeleteOperationCompleted(object arg)
		{
			if (this.DeleteCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.DeleteCompleted(this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Retrieve", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CallerOriginTokenValue"), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue")]
		public BusinessEntity Retrieve(string entityName, Guid id, ColumnSetBase columnSet)
		{
			object[] results = base.Invoke("Retrieve", new object[]
			{
				entityName,
				id,
				columnSet
			});
			return (BusinessEntity)results[0];
		}
		public void RetrieveAsync(string entityName, Guid id, ColumnSetBase columnSet)
		{
			this.RetrieveAsync(entityName, id, columnSet, null);
		}
		public void RetrieveAsync(string entityName, Guid id, ColumnSetBase columnSet, object userState)
		{
			if (this.RetrieveOperationCompleted == null)
			{
				this.RetrieveOperationCompleted = new SendOrPostCallback(this.OnRetrieveOperationCompleted);
			}
			base.InvokeAsync("Retrieve", new object[]
			{
				entityName,
				id,
				columnSet
			}, this.RetrieveOperationCompleted, userState);
		}
		private void OnRetrieveOperationCompleted(object arg)
		{
			if (this.RetrieveCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.RetrieveCompleted(this, new RetrieveCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/RetrieveMultiple", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue"), SoapHeader("CallerOriginTokenValue")]
		public BusinessEntityCollection RetrieveMultiple(QueryBase query)
		{
			object[] results = base.Invoke("RetrieveMultiple", new object[]
			{
				query
			});
			return (BusinessEntityCollection)results[0];
		}
		public void RetrieveMultipleAsync(QueryBase query)
		{
			this.RetrieveMultipleAsync(query, null);
		}
		public void RetrieveMultipleAsync(QueryBase query, object userState)
		{
			if (this.RetrieveMultipleOperationCompleted == null)
			{
				this.RetrieveMultipleOperationCompleted = new SendOrPostCallback(this.OnRetrieveMultipleOperationCompleted);
			}
			base.InvokeAsync("RetrieveMultiple", new object[]
			{
				query
			}, this.RetrieveMultipleOperationCompleted, userState);
		}
		private void OnRetrieveMultipleOperationCompleted(object arg)
		{
			if (this.RetrieveMultipleCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.RetrieveMultipleCompleted(this, new RetrieveMultipleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
			}
		}
		[SoapDocumentMethod("http://schemas.microsoft.com/crm/2007/WebServices/Update", RequestNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", ResponseNamespace = "http://schemas.microsoft.com/crm/2007/WebServices", Use = SoapBindingUse.Literal, ParameterStyle = SoapParameterStyle.Wrapped), SoapHeader("CorrelationTokenValue"), SoapHeader("CrmAuthenticationTokenValue"), SoapHeader("CallerOriginTokenValue")]
		public void Update(BusinessEntity entity)
		{
			base.Invoke("Update", new object[]
			{
				entity
			});
		}
		public void UpdateAsync(BusinessEntity entity)
		{
			this.UpdateAsync(entity, null);
		}
		public void UpdateAsync(BusinessEntity entity, object userState)
		{
			if (this.UpdateOperationCompleted == null)
			{
				this.UpdateOperationCompleted = new SendOrPostCallback(this.OnUpdateOperationCompleted);
			}
			base.InvokeAsync("Update", new object[]
			{
				entity
			}, this.UpdateOperationCompleted, userState);
		}
		private void OnUpdateOperationCompleted(object arg)
		{
			if (this.UpdateCompleted != null)
			{
				InvokeCompletedEventArgs invokeArgs = (InvokeCompletedEventArgs)arg;
				this.UpdateCompleted(this, new AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
