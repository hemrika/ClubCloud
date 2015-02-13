using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.DuplicaatPersonen
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class DuplicaatPersonenServiceSoapClient : ClientBase<DuplicaatPersonenServiceSoap>, DuplicaatPersonenServiceSoap
    {
        private ClientBase<DuplicaatPersonenServiceSoap>.BeginOperationDelegate onBeginDuplicaatpersonenFoundDelegate;

        private ClientBase<DuplicaatPersonenServiceSoap>.EndOperationDelegate onEndDuplicaatpersonenFoundDelegate;

        private SendOrPostCallback onDuplicaatpersonenFoundCompletedDelegate;

        public DuplicaatPersonenServiceSoapClient()
        {
        }

        public DuplicaatPersonenServiceSoapClient(string endpointConfigurationName)
            : base(endpointConfigurationName)
        {
        }

        public DuplicaatPersonenServiceSoapClient(string endpointConfigurationName, string remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public DuplicaatPersonenServiceSoapClient(string endpointConfigurationName, EndpointAddress remoteAddress)
            : base(endpointConfigurationName, remoteAddress)
        {
        }

        public DuplicaatPersonenServiceSoapClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public IAsyncResult BeginDuplicaatpersonenFound(OrganizationHeader OrganizationHeader, string achternaam, string voorletters, string roepnaam, string geboortedatum, int geslacht, string postcode, string huisnummer, string origin, string type, AsyncCallback callback, object asyncState)
        {
            DuplicaatpersonenFoundRequest inValue = new DuplicaatpersonenFoundRequest()
            {
                OrganizationHeader = OrganizationHeader,
                achternaam = achternaam,
                voorletters = voorletters,
                roepnaam = roepnaam,
                geboortedatum = geboortedatum,
                geslacht = geslacht,
                postcode = postcode,
                huisnummer = huisnummer,
                origin = origin,
                type = type
            };
            return ((DuplicaatPersonenServiceSoap)this).BeginDuplicaatpersonenFound(inValue, callback, asyncState);
        }

        public bool DuplicaatpersonenFound(OrganizationHeader OrganizationHeader, string achternaam, string voorletters, string roepnaam, string geboortedatum, int geslacht, string postcode, string huisnummer, string origin, string type)
        {
            DuplicaatpersonenFoundRequest inValue = new DuplicaatpersonenFoundRequest()
            {
                OrganizationHeader = OrganizationHeader,
                achternaam = achternaam,
                voorletters = voorletters,
                roepnaam = roepnaam,
                geboortedatum = geboortedatum,
                geslacht = geslacht,
                postcode = postcode,
                huisnummer = huisnummer,
                origin = origin,
                type = type
            };
            return ((DuplicaatPersonenServiceSoap)this).DuplicaatpersonenFound(inValue).DuplicaatpersonenFoundResult;
        }

        public void DuplicaatpersonenFoundAsync(OrganizationHeader OrganizationHeader, string achternaam, string voorletters, string roepnaam, string geboortedatum, int geslacht, string postcode, string huisnummer, string origin, string type)
        {
            this.DuplicaatpersonenFoundAsync(OrganizationHeader, achternaam, voorletters, roepnaam, geboortedatum, geslacht, postcode, huisnummer, origin, type, null);
        }

        public void DuplicaatpersonenFoundAsync(OrganizationHeader OrganizationHeader, string achternaam, string voorletters, string roepnaam, string geboortedatum, int geslacht, string postcode, string huisnummer, string origin, string type, object userState)
		{
			if (this.onBeginDuplicaatpersonenFoundDelegate == null)
			{
				this.onBeginDuplicaatpersonenFoundDelegate = new ClientBase<DuplicaatPersonenServiceSoap>.BeginOperationDelegate(this.OnBeginDuplicaatpersonenFound);
			}
			if (this.onEndDuplicaatpersonenFoundDelegate == null)
			{
				this.onEndDuplicaatpersonenFoundDelegate = new ClientBase<DuplicaatPersonenServiceSoap>.EndOperationDelegate(this.OnEndDuplicaatpersonenFound);
			}
			if (this.onDuplicaatpersonenFoundCompletedDelegate == null)
			{
				this.onDuplicaatpersonenFoundCompletedDelegate = new SendOrPostCallback(this.OnDuplicaatpersonenFoundCompleted);
			}
			ClientBase<DuplicaatPersonenServiceSoap>.BeginOperationDelegate beginOperationDelegate = this.onBeginDuplicaatpersonenFoundDelegate;
			object[] organizationHeader = new object[] { OrganizationHeader, achternaam, voorletters, roepnaam, geboortedatum, geslacht, postcode, huisnummer, origin, type };
			//base.InvokeAsync((ClientBase<!0>.BeginOperationDelegate)beginOperationDelegate, organizationHeader, this.onEndDuplicaatpersonenFoundDelegate, this.onDuplicaatpersonenFoundCompletedDelegate, userState);
		}

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        public bool EndDuplicaatpersonenFound(IAsyncResult result)
        {
            return ((DuplicaatPersonenServiceSoap)this).EndDuplicaatpersonenFound(result).DuplicaatpersonenFoundResult;
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        IAsyncResult DuplicaatPersonenServiceSoap.BeginDuplicaatpersonenFound(DuplicaatpersonenFoundRequest request, AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginDuplicaatpersonenFound(request, callback, asyncState);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        DuplicaatpersonenFoundResponse DuplicaatPersonenServiceSoap.DuplicaatpersonenFound(DuplicaatpersonenFoundRequest request)
        {
            return base.Channel.DuplicaatpersonenFound(request);
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        DuplicaatpersonenFoundResponse DuplicaatPersonenServiceSoap.EndDuplicaatpersonenFound(IAsyncResult result)
        {
            return base.Channel.EndDuplicaatpersonenFound(result);
        }

        private IAsyncResult OnBeginDuplicaatpersonenFound(object[] inValues, AsyncCallback callback, object asyncState)
        {
            OrganizationHeader OrganizationHeader = (OrganizationHeader)inValues[0];
            string achternaam = (string)inValues[1];
            string voorletters = (string)inValues[2];
            string roepnaam = (string)inValues[3];
            string geboortedatum = (string)inValues[4];
            int geslacht = (int)inValues[5];
            string postcode = (string)inValues[6];
            string huisnummer = (string)inValues[7];
            string origin = (string)inValues[8];
            string type = (string)inValues[9];
            return this.BeginDuplicaatpersonenFound(OrganizationHeader, achternaam, voorletters, roepnaam, geboortedatum, geslacht, postcode, huisnummer, origin, type, callback, asyncState);
        }

        private void OnDuplicaatpersonenFoundCompleted(object state)
        {
            if (this.DuplicaatpersonenFoundCompleted != null)
            {
                ClientBase<DuplicaatPersonenServiceSoap>.InvokeAsyncCompletedEventArgs e = (ClientBase<DuplicaatPersonenServiceSoap>.InvokeAsyncCompletedEventArgs)state;
                this.DuplicaatpersonenFoundCompleted(this, new DuplicaatpersonenFoundCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }

        private object[] OnEndDuplicaatpersonenFound(IAsyncResult result)
        {
            return new object[] { this.EndDuplicaatpersonenFound(result) };
        }

        public event EventHandler<DuplicaatpersonenFoundCompletedEventArgs> DuplicaatpersonenFoundCompleted;
    }

}
