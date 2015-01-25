using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class CompetitieServiceClient : ChannelFactory<ClubCloud.KNLTB.ServIt.CompetitieService.ICompetitieService>, ICompetitieService//ClientBase<ICompetitieService>, ICompetitieService
	{
        private static Uri serverUri = new Uri("https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Services/CompetitieService.svc");
        private static BasicHttpsSecurity security = new BasicHttpsSecurity { Mode = BasicHttpsSecurityMode.Transport, Transport = new HttpTransportSecurity { ClientCredentialType = HttpClientCredentialType.Basic, Realm = "servit.mijnknltb.nl" } };

        public CompetitieServiceClient(CookieContainer cookiecontainer, string bondsnummer)
            : this(new BasicHttpsBinding() { Security = security, AllowCookies = true, HostNameComparisonMode = HostNameComparisonMode.WeakWildcard }, new EndpointAddress(serverUri))
		{
            cookieContainer = cookiecontainer;
            this.Credentials.UserName.UserName = bondsnummer;
		}

        private CompetitieServiceClient(Binding binding, EndpointAddress remoteAddress)
            : base(binding, remoteAddress)
        {
        }

        private static CookieContainer _cookieContainer;
        private CookieContainer cookieContainer
        {
            get
            {
                return _cookieContainer;
            }
            set
            {
                _cookieContainer = value;
            }
        }

        private static ICompetitieService competitieService;

        private ICompetitieService CompetitieService
        {
            get
            {
                if (competitieService == null)
                {
                    competitieService = this.CreateChannel();
                    GetProperty<IHttpCookieContainerManager>().CookieContainer = cookieContainer;
                }
                return competitieService;
            }
        }

		public GetAfdelingenResponse GetAfdelingen(GetAfdelingenRequest request)
		{
			return CompetitieService.GetAfdelingen(request);
		}

		public Task<GetAfdelingenResponse> GetAfdelingenAsync(GetAfdelingenRequest request)
		{
			return CompetitieService.GetAfdelingenAsync(request);
		}

		public GetCompetitiesResponse GetCompetities(GetCompetitiesRequest request)
		{
			return CompetitieService.GetCompetities(request);
		}

		public Task<GetCompetitiesResponse> GetCompetitiesAsync(GetCompetitiesRequest request)
		{
			return CompetitieService.GetCompetitiesAsync(request);
		}

		public GetCompetitiesForInschrijvingResponse GetCompetitiesForInschrijving(GetCompetitiesForInschrijvingRequest request)
		{
			return CompetitieService.GetCompetitiesForInschrijving(request);
		}

		public Task<GetCompetitiesForInschrijvingResponse> GetCompetitiesForInschrijvingAsync(GetCompetitiesForInschrijvingRequest request)
		{
			return CompetitieService.GetCompetitiesForInschrijvingAsync(request);
		}

		public GetKlassengroepenResponse GetKlassengroepen(GetKlassengroepenRequest request)
		{
			return CompetitieService.GetKlassengroepen(request);
		}

		public Task<GetKlassengroepenResponse> GetKlassengroepenAsync(GetKlassengroepenRequest request)
		{
			return CompetitieService.GetKlassengroepenAsync(request);
		}

		public GetKlassengroepenForInschrijvingResponse GetKlassengroepenForInschrijving(GetKlassengroepenForInschrijvingRequest request)
		{
			return CompetitieService.GetKlassengroepenForInschrijving(request);
		}

		public Task<GetKlassengroepenForInschrijvingResponse> GetKlassengroepenForInschrijvingAsync(GetKlassengroepenForInschrijvingRequest request)
		{
			return CompetitieService.GetKlassengroepenForInschrijvingAsync(request);
		}

		public GetPartijresultatenResponse GetPartijresultaten(GetPartijresultatenRequest request)
		{
			return CompetitieService.GetPartijresultaten(request);
		}

		public Task<GetPartijresultatenResponse> GetPartijresultatenAsync(GetPartijresultatenRequest request)
		{
			return CompetitieService.GetPartijresultatenAsync(request);
		}

		public GetPloegenResponse GetPloegen(GetPloegenRequest request)
		{
			return CompetitieService.GetPloegen(request);
		}

		public Task<GetPloegenResponse> GetPloegenAsync(GetPloegenRequest request)
		{
			return CompetitieService.GetPloegenAsync(request);
		}

		public GetStandenResponse GetStanden(GetStandenRequest request)
		{
			return CompetitieService.GetStanden(request);
		}

		public Task<GetStandenResponse> GetStandenAsync(GetStandenRequest request)
		{
			return CompetitieService.GetStandenAsync(request);
		}

		public GetUitslagenAfdelingResponse GetUitslagenAfdeling(GetUitslagenAfdelingRequest request)
		{
			return CompetitieService.GetUitslagenAfdeling(request);
		}

		public Task<GetUitslagenAfdelingResponse> GetUitslagenAfdelingAsync(GetUitslagenAfdelingRequest request)
		{
			return CompetitieService.GetUitslagenAfdelingAsync(request);
		}

		public GetVerenigingenResponse GetVerenigingen(GetVerenigingenRequest request)
		{
			return CompetitieService.GetVerenigingen(request);
		}

		public Task<GetVerenigingenResponse> GetVerenigingenAsync(GetVerenigingenRequest request)
		{
			return CompetitieService.GetVerenigingenAsync(request);
		}

		public GetWedstrijdgegevensResponse GetWedstrijdgegevens(GetWedstrijdgegevensRequest request)
		{
			return CompetitieService.GetWedstrijdgegevens(request);
		}

		public Task<GetWedstrijdgegevensResponse> GetWedstrijdgegevensAsync(GetWedstrijdgegevensRequest request)
		{
			return CompetitieService.GetWedstrijdgegevensAsync(request);
		}

		public ZoekIngedeeldePloegenResponse ZoekIngedeeldePloegen(ZoekIngedeeldePloegenRequest request)
		{
			return CompetitieService.ZoekIngedeeldePloegen(request);
		}

		public Task<ZoekIngedeeldePloegenResponse> ZoekIngedeeldePloegenAsync(ZoekIngedeeldePloegenRequest request)
		{
			return CompetitieService.ZoekIngedeeldePloegenAsync(request);
		}

		public ZoekWedstrijdgegevensResponse ZoekWedstrijdgegevens(ZoekWedstrijdgegevensRequest request)
		{
			return CompetitieService.ZoekWedstrijdgegevens(request);
		}

		public Task<ZoekWedstrijdgegevensResponse> ZoekWedstrijdgegevensAsync(ZoekWedstrijdgegevensRequest request)
		{
			return CompetitieService.ZoekWedstrijdgegevensAsync(request);
		}
	}
}