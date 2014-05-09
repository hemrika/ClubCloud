using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Services;
using System.Web.Services.Description;
using System.Web.Services.Protocols;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt
{
    /*
    public delegate void DeleteCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
    public delegate void ExecuteCompletedEventHandler(object sender, ExecuteCompletedEventArgs e);
    public delegate void FetchCompletedEventHandler(object sender, FetchCompletedEventArgs e);
    public delegate void RetrieveCompletedEventHandler(object sender, RetrieveCompletedEventArgs e);
    public delegate void RetrieveMultipleCompletedEventHandler(object sender, RetrieveMultipleCompletedEventArgs e);
    public delegate void UpdateCompletedEventHandler(object sender, AsyncCompletedEventArgs e);
    */
    [WebServiceBinding(Name = "CrmServiceSoap", Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
    [XmlInclude(typeof(activityparty[]))]
    [XmlInclude(typeof(CrmReference))]
    [XmlInclude(typeof(Property[]))]
    public class CrmServiceSoapClient : SoapHttpClientProtocol /*ClientBase<CrmServiceSoap>*/, CrmServiceSoap
	{
        private SendOrPostCallback ExecuteOperationCompleted;

        private SendOrPostCallback FetchOperationCompleted;

        private SendOrPostCallback CreateOperationCompleted;

        private SendOrPostCallback DeleteOperationCompleted;

        private SendOrPostCallback RetrieveOperationCompleted;

        private SendOrPostCallback RetrieveMultipleOperationCompleted;

        private SendOrPostCallback UpdateOperationCompleted;

        public event CreateCompletedEventHandler CreateCompleted;

        public event DeleteCompletedEventHandler DeleteCompleted;

        public event ExecuteCompletedEventHandler ExecuteCompleted;

        public event FetchCompletedEventHandler FetchCompleted;

        public event RetrieveCompletedEventHandler RetrieveCompleted;

        public event RetrieveMultipleCompletedEventHandler RetrieveMultipleCompleted;

        public event UpdateCompletedEventHandler UpdateCompleted;

		public CrmServiceSoapClient()
		{
		}

        private CallerOriginToken callerOriginTokenValueField;

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

        private CorrelationToken correlationTokenValueField;

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

        private CrmAuthenticationToken crmAuthenticationTokenValueField;

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

        public new void CancelAsync(object userState)
        {
            base.CancelAsync(userState);
        }

        #region Execute

        ExecuteResponse CrmServiceSoap.Execute(ExecuteRequest request)
        {
            try
            {
                object[] parameters = new object[] { request.Request };
                //return (ExecuteResponse)base.Invoke("http://schemas.microsoft.com/crm/2007/WebServices/Execute", parameters)[0];
                return (ExecuteResponse)base.Invoke("Execute", parameters)[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw ex;
            }
        }

		public Response Execute(Request Request)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, Request Request)
		{
			ExecuteResponse retVal = ((CrmServiceSoap)this).Execute(new ExecuteRequest
			{
				CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
				Request = Request
			});
			return retVal.Response;
		}

        public Task<ExecuteResponse> ExecuteAsync(ExecuteRequest Request)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, Request Request)
        {
            return ((CrmServiceSoap)this).ExecuteAsync(new ExecuteRequest
            {
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                Request = Request.Request
            });
        }
        /*
        void ExecuteAsync(ExecuteRequest request)
        {
            this.ExecuteAsync(request, null);
            //return base.Channel.ExecuteAsync(request);
        }
        */
        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void ExecuteAsync(ExecuteRequest Request, object userState)
        {
            if (this.ExecuteOperationCompleted == null)
            {
                this.ExecuteOperationCompleted = new SendOrPostCallback(this.OnExecuteOperationCompleted);
            }
            object[] request = new object[] { Request };
            base.InvokeAsync("Execute", request, this.ExecuteOperationCompleted, userState);
        }

        private void OnExecuteOperationCompleted(object arg)
        {
            if (this.ExecuteCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.ExecuteCompleted(this, new ExecuteCompletedEventArgs(invokeCompletedEventArg.Results, invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginExecute(Request Request, AsyncCallback callback, object asyncState)
        {
            object[] request = new object[] { Request };
            return this.BeginInvoke("Execute", request, callback, asyncState);
        }

        public Response EndExecute(IAsyncResult asyncResult)
        {
            return (Response)base.EndInvoke(asyncResult)[0];
        }

        #endregion

        #region Fetch

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		FetchResponse CrmServiceSoap.Fetch(FetchRequest request)
		{
            object[] parameters = new object[] { request };
            return (FetchResponse)base.Invoke("Fetch", parameters)[0];
			//return base.Channel.Fetch(request);
		}

		public string Fetch(string fetchXml)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string fetchXml)
		{
			FetchResponse retVal = ((CrmServiceSoap)this).Fetch(new FetchRequest
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                fetchXml = fetchXml
			});
			return retVal.FetchResult;
		}

        public Task<FetchResponse> FetchAsync(FetchRequest fetchXml)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string fetchXml)
        {
            return ((CrmServiceSoap)this).FetchAsync(new FetchRequest
            {
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                fetchXml = fetchXml.fetchXml
            });
        }

		/*
		void CrmServiceSoap.FetchAsync(FetchRequest request)
		{
            this.FetchAsync(request, null);
			//return base.Channel.FetchAsync(request);
		}
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void FetchAsync(FetchRequest fetchXml, object userState)
        {
            if (this.FetchOperationCompleted == null)
            {
                this.FetchOperationCompleted = new SendOrPostCallback(this.OnFetchOperationCompleted);
            }
            object[] objArray = new object[] { fetchXml };
            base.InvokeAsync("Fetch", objArray, this.FetchOperationCompleted, userState);
        }

        private void OnFetchOperationCompleted(object arg)
        {
            if (this.FetchCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.FetchCompleted(this, new FetchCompletedEventArgs(invokeCompletedEventArg.Results, invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginFetch(FetchRequest fetchXml, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { fetchXml };
            return base.BeginInvoke("Fetch", objArray, callback, asyncState);
        }

        public string EndFetch(IAsyncResult asyncResult)
        {
            return (string)base.EndInvoke(asyncResult)[0];
        }

        #endregion

        #region Create

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		CreateResponse1 CrmServiceSoap.Create(CreateRequest1 request)
		{
            object[] parameters = new object[] { request };
            return (CreateResponse1)base.Invoke("Create", parameters)[0];
            //return base.Channel.Create(request);
		}
		public Guid Create(BusinessEntity entity)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, BusinessEntity entity)
		{
			CreateResponse1 retVal = ((CrmServiceSoap)this).Create(new CreateRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entity = entity
			});
			return retVal.CreateResult;
		}

        public Task<CreateResponse1> CreateAsync(CreateRequest1 entity)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, BusinessEntity entity)
        {
            return ((CrmServiceSoap)this).CreateAsync(new CreateRequest1
            {
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entity = entity.entity
            });
        }

		/*
		void CrmServiceSoap.CreateAsync(CreateRequest1 request)
		{
			this.CreateAsync(request.entity,null);
		}
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void CreateAsync(BusinessEntity entity, object userState)
        {
            if (this.CreateOperationCompleted == null)
            {
                this.CreateOperationCompleted = new SendOrPostCallback(this.OnCreateOperationCompleted);
            }
            object[] objArray = new object[] { entity };
            base.InvokeAsync("Create", objArray, this.CreateOperationCompleted, userState);
        }

        private void OnCreateOperationCompleted(object arg)
        {
            if (this.CreateCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.CreateCompleted(this, new CreateCompletedEventArgs(invokeCompletedEventArg.Results, invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginCreate(BusinessEntity entity, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { entity };
            return base.BeginInvoke("Create", objArray, callback, asyncState);
        }

        public Guid EndCreate(IAsyncResult asyncResult)
        {
            return (Guid)base.EndInvoke(asyncResult)[0];
        }

        #endregion

        #region Delete

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		DeleteResponse1 CrmServiceSoap.Delete(DeleteRequest1 request)
		{
            object[] parameters = new object[] { request.entityName,request.id };
            return (DeleteResponse1)base.Invoke("Delete", parameters)[0];
			//return base.Channel.Delete(request);
		}

		public void Delete(string entityName, Guid id)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string entityName, Guid id)
		{
			DeleteResponse1 retVal = ((CrmServiceSoap)this).Delete(new DeleteRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entityName = entityName,
				id = id
			});
		}

        public Task<DeleteResponse1> DeleteAsync(DeleteRequest1 request)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string entityName, Guid id)
        {
            return ((CrmServiceSoap)this).DeleteAsync(new DeleteRequest1
            {
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entityName = request.entityName,
                id = request.id
            });
        }

        /*
        void CrmServiceSoap.DeleteAsync(DeleteRequest1 request)
        {
            this.DeleteAsync(request.entityName, request.id, null);
        }
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void DeleteAsync(string entityName, Guid id, object userState)
        {
            if (this.DeleteOperationCompleted == null)
            {
                this.DeleteOperationCompleted = new SendOrPostCallback(this.OnDeleteOperationCompleted);
            }
            object[] objArray = new object[] { entityName, id };
            base.InvokeAsync("Delete", objArray, this.DeleteOperationCompleted, userState);
        }

        private void OnDeleteOperationCompleted(object arg)
        {
            if (this.DeleteCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.DeleteCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginDelete(string entityName, Guid id, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { entityName, id };
            return base.BeginInvoke("Delete", objArray, callback, asyncState);
        }

        public void EndDelete(IAsyncResult asyncResult)
        {
            base.EndInvoke(asyncResult);
        }

        #endregion

        #region Retrieve

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		RetrieveResponse1 CrmServiceSoap.Retrieve(RetrieveRequest1 request)
		{
            object[] parameters = new object[] { request };
            return (RetrieveResponse1)base.Invoke("Retrieve", parameters)[0];
			//return base.Channel.Retrieve(request);
		}
		public BusinessEntity Retrieve(string entityName, Guid id, ColumnSetBase columnSet)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string entityName, Guid id, ColumnSetBase columnSet)
		{
			RetrieveResponse1 retVal = ((CrmServiceSoap)this).Retrieve(new RetrieveRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entityName = entityName,
				id = id,
				columnSet = columnSet
			});
			return retVal.RetrieveResult;
		}

		public Task<RetrieveResponse1> RetrieveAsync(RetrieveRequest1 request)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, string entityName, Guid id, ColumnSetBase columnSet)
		{
			return ((CrmServiceSoap)this).RetrieveAsync(new RetrieveRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entityName = request.entityName,
                id = request.id,
                columnSet = request.columnSet
			});
		}

        /*
        void CrmServiceSoap.RetrieveAsync(RetrieveRequest1 request)
        {
            this.RetrieveAsync(request.entityName, request.id, request.columnSet, null);
        }
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void RetrieveAsync(string entityName, Guid id, ColumnSetBase columnSet, object userState)
        {
            if (this.RetrieveOperationCompleted == null)
            {
                this.RetrieveOperationCompleted = new SendOrPostCallback(this.OnRetrieveOperationCompleted);
            }
            object[] objArray = new object[] { entityName, id, columnSet };
            base.InvokeAsync("Retrieve", objArray, this.RetrieveOperationCompleted, userState);
        }

        private void OnRetrieveOperationCompleted(object arg)
        {
            if (this.RetrieveCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.RetrieveCompleted(this, new RetrieveCompletedEventArgs(invokeCompletedEventArg.Results, invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginRetrieve(string entityName, Guid id, ColumnSetBase columnSet, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { entityName, id, columnSet };
            return base.BeginInvoke("Retrieve", objArray, callback, asyncState);
        }

        public BusinessEntity EndRetrieve(IAsyncResult asyncResult)
        {
            return (BusinessEntity)base.EndInvoke(asyncResult)[0];
        }

        #endregion

        #region RetrieveMultiple

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		RetrieveMultipleResponse1 CrmServiceSoap.RetrieveMultiple(RetrieveMultipleRequest1 request)
		{
            object[] parameters = new object[] { request.query };
            return (RetrieveMultipleResponse1)base.Invoke("RetrieveMultiple", parameters)[0];
			//return base.Channel.RetrieveMultiple(request);
		}
		public BusinessEntityCollection RetrieveMultiple(QueryBase query)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, QueryBase query)
		{
			RetrieveMultipleResponse1 retVal = ((CrmServiceSoap)this).RetrieveMultiple(new RetrieveMultipleRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                query = query
			});
			return retVal.RetrieveMultipleResult;
		}

        public Task<RetrieveMultipleResponse1> RetrieveMultipleAsync(RetrieveMultipleRequest1 request)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, QueryBase query)
		{
			return ((CrmServiceSoap)this).RetrieveMultipleAsync(new RetrieveMultipleRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                query = request.query
			});
		}

        /*
        void CrmServiceSoap.RetrieveMultipleAsync(RetrieveMultipleRequest1 request)
        {
            this.RetrieveMultipleAsync(request.query, null);
        }
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public void RetrieveMultipleAsync(QueryBase query, object userState)
        {
            if (this.RetrieveMultipleOperationCompleted == null)
            {
                this.RetrieveMultipleOperationCompleted = new SendOrPostCallback(this.OnRetrieveMultipleOperationCompleted);
            }
            object[] objArray = new object[] { query };
            base.InvokeAsync("RetrieveMultiple", objArray, this.RetrieveMultipleOperationCompleted, userState);
        }

        private void OnRetrieveMultipleOperationCompleted(object arg)
        {
            if (this.RetrieveMultipleCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.RetrieveMultipleCompleted(this, new RetrieveMultipleCompletedEventArgs(invokeCompletedEventArg.Results, invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginRetrieveMultiple(QueryBase query, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { query };
            return base.BeginInvoke("RetrieveMultiple", objArray, callback, asyncState);
        }

        public BusinessEntityCollection EndRetrieveMultiple(IAsyncResult asyncResult)
        {
            return (BusinessEntityCollection)base.EndInvoke(asyncResult)[0];
        }

        #endregion

        #region Update

        [EditorBrowsable(EditorBrowsableState.Advanced)]
		UpdateResponse1 CrmServiceSoap.Update(UpdateRequest1 request)
		{
            object[] parameters = new object[] { request };
            return (UpdateResponse1)base.Invoke("Update", parameters)[0];
			//return base.Channel.Update(request);
		}
		public void Update(BusinessEntity entity)//(CrmAuthenticationToken CrmAuthenticationToken, CallerOriginToken CallerOriginToken, CorrelationToken CorrelationToken, BusinessEntity entity)
		{
			UpdateResponse1 retVal = ((CrmServiceSoap)this).Update(new UpdateRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entity = entity
			});
		}

        Task<UpdateResponse1> CrmServiceSoap.UpdateAsync(UpdateRequest1 request)
        {
            throw new NotImplementedException();
        }
		public Task<UpdateResponse1> UpdateAsync(UpdateRequest1 request)
		{
			return ((CrmServiceSoap)this).UpdateAsync(new UpdateRequest1
			{
                CrmAuthenticationToken = CrmAuthenticationTokenValue, //CrmAuthenticationToken,
                CallerOriginToken = CallerOriginTokenValue, //CallerOriginToken,
                CorrelationToken = CorrelationTokenValue, //CorrelationToken,
                entity = request.entity
			});
        }

        /*
        void CrmServiceSoap.UpdateAsync(UpdateRequest1 request)
        {
            this.UpdateAsync(request.entity);
        }
        */

        [EditorBrowsable(EditorBrowsableState.Advanced)]
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
            object[] objArray = new object[] { entity };
            base.InvokeAsync("Update", objArray, this.UpdateOperationCompleted, userState);
        }

        private void OnUpdateOperationCompleted(object arg)
        {
            if (this.UpdateCompleted != null)
            {
                InvokeCompletedEventArgs invokeCompletedEventArg = (InvokeCompletedEventArgs)arg;
                this.UpdateCompleted(this, new AsyncCompletedEventArgs(invokeCompletedEventArg.Error, invokeCompletedEventArg.Cancelled, invokeCompletedEventArg.UserState));
            }
        }

        public IAsyncResult BeginUpdate(BusinessEntity entity, AsyncCallback callback, object asyncState)
        {
            object[] objArray = new object[] { entity };
            return base.BeginInvoke("Update", objArray, callback, asyncState);
        }

        public void EndUpdate(IAsyncResult asyncResult)
        {
            base.EndInvoke(asyncResult);
        }

        #endregion
    }
}
