using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Security;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DebuggerStepThrough]
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class LedenadministratieServiceClient : ChannelFactory<ClubCloud.KNLTB.ServIt.LedenAdministratieService.ILedenadministratieService>, ILedenadministratieService// ClientBase<ILedenadministratieService>, ILedenadministratieService
	{
        private static Uri serverUri = new Uri("https://servit.mijnknltb.nl/ISV/KNLTB.ServIT2/KNLTB/Services/LedenAdministratieService.svc");
        private static BasicHttpsSecurity security = new BasicHttpsSecurity { Mode = BasicHttpsSecurityMode.Transport, Transport = new HttpTransportSecurity { ClientCredentialType = HttpClientCredentialType.Basic, Realm = "servit.mijnknltb.nl" } };

		public LedenadministratieServiceClient(CookieContainer cookiecontainer,string bondsnummer)
            : this(new BasicHttpsBinding() { Security= security,  AllowCookies = true, HostNameComparisonMode = HostNameComparisonMode.WeakWildcard }, new EndpointAddress(serverUri))
		{
            cookieContainer = cookiecontainer;
            this.Credentials.UserName.UserName = bondsnummer;
		}

        private LedenadministratieServiceClient(Binding binding, EndpointAddress remoteAddress)
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

        private static ILedenadministratieService ledenadministratieService;

        private ILedenadministratieService LedenadministratieService
        {
            get
            {
                if (ledenadministratieService == null)
                {
                    ledenadministratieService = this.CreateChannel();
                    GetProperty<IHttpCookieContainerManager>().CookieContainer = cookieContainer;
                }
                return ledenadministratieService;
            }
        }

		public CreateIdealPaymentResponse CreateIdealEventsPayment(CreateIdealEventsPaymentRequest request)
		{
			return LedenadministratieService.CreateIdealEventsPayment(request);
		}

		public Task<CreateIdealPaymentResponse> CreateIdealEventsPaymentAsync(CreateIdealEventsPaymentRequest request)
		{
			return LedenadministratieService.CreateIdealEventsPaymentAsync(request);
		}

		public CreateIdealPaymentResponse CreateIdealPayment(CreateIdealPaymentRequest request)
		{
			return LedenadministratieService.CreateIdealPayment(request);
		}

		public Task<CreateIdealPaymentResponse> CreateIdealPaymentAsync(CreateIdealPaymentRequest request)
		{
			return LedenadministratieService.CreateIdealPaymentAsync(request);
		}

		public CreateIdealPaymentControlResponse CreateIdealPaymentControl(CreateIdealPaymentControlRequest request)
		{
			return LedenadministratieService.CreateIdealPaymentControl(request);
		}

		public Task<CreateIdealPaymentControlResponse> CreateIdealPaymentControlAsync(CreateIdealPaymentControlRequest request)
		{
			return LedenadministratieService.CreateIdealPaymentControlAsync(request);
		}

		public GetAccommodatieResponse GetAccommodatie(GetAccommodatieRequest request)
		{
			return LedenadministratieService.GetAccommodatie(request);
		}

		public Task<GetAccommodatieResponse> GetAccommodatieAsync(GetAccommodatieRequest request)
		{
			return LedenadministratieService.GetAccommodatieAsync(request);
		}

		public GetAccommodatieForVerenigingResponse GetAccommodatieForVereniging(GetAccommodatieForVerenigingRequest request)
		{
			return LedenadministratieService.GetAccommodatieForVereniging(request);
		}

		public Task<GetAccommodatieForVerenigingResponse> GetAccommodatieForVerenigingAsync(GetAccommodatieForVerenigingRequest request)
		{
			return LedenadministratieService.GetAccommodatieForVerenigingAsync(request);
		}

		public GetBasisOrganisatieForSpecifiekResponse GetBasisOrganisatieForSpecifiek(GetBasisOrganisatieForSpecifiekRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieForSpecifiek(request);
		}

		public Task<GetBasisOrganisatieForSpecifiekResponse> GetBasisOrganisatieForSpecifiekAsync(GetBasisOrganisatieForSpecifiekRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieForSpecifiekAsync(request);
		}

		public GetBasisOrganisatieForTypeResponse GetBasisOrganisatieForType(GetBasisOrganisatieForTypeRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieForType(request);
		}

		public Task<GetBasisOrganisatieForTypeResponse> GetBasisOrganisatieForTypeAsync(GetBasisOrganisatieForTypeRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieForTypeAsync(request);
		}

		public GetBasisOrganisatieLandelijkResponse GetBasisOrganisatieLandelijk(GetBasisOrganisatieLandelijkRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieLandelijk(request);
		}

		public Task<GetBasisOrganisatieLandelijkResponse> GetBasisOrganisatieLandelijkAsync(GetBasisOrganisatieLandelijkRequest request)
		{
			return LedenadministratieService.GetBasisOrganisatieLandelijkAsync(request);
		}

		public GetBasisorganisatiesResponse GetBasisorganisaties(GetBasisorganisatiesRequest request)
		{
			return LedenadministratieService.GetBasisorganisaties(request);
		}

		public Task<GetBasisorganisatiesResponse> GetBasisorganisatiesAsync(GetBasisorganisatiesRequest request)
		{
			return LedenadministratieService.GetBasisorganisatiesAsync(request);
		}

		public GetBestuursorganenForVerenigingResponse GetBestuursorganenForVereniging(GetBestuursorganenForVerenigingRequest request)
		{
			return LedenadministratieService.GetBestuursorganenForVereniging(request);
		}

		public Task<GetBestuursorganenForVerenigingResponse> GetBestuursorganenForVerenigingAsync(GetBestuursorganenForVerenigingRequest request)
		{
			return LedenadministratieService.GetBestuursorganenForVerenigingAsync(request);
		}

		public GetCompetitiesForVerenigingResponse GetCompetitiesForVereniging(GetCompetitiesForVerenigingRequest request)
		{
			return LedenadministratieService.GetCompetitiesForVereniging(request);
		}

		public Task<GetCompetitiesForVerenigingResponse> GetCompetitiesForVerenigingAsync(GetCompetitiesForVerenigingRequest request)
		{
			return LedenadministratieService.GetCompetitiesForVerenigingAsync(request);
		}

		public GetDistrictResponse GetDistrict(GetDistrictRequest request)
		{
			return LedenadministratieService.GetDistrict(request);
		}

		public Task<GetDistrictResponse> GetDistrictAsync(GetDistrictRequest request)
		{
			return LedenadministratieService.GetDistrictAsync(request);
		}

		public GetMijnVerenigingenResponse GetMijnVerenigingen(GetMijnVerenigingenRequest request)
		{
			return LedenadministratieService.GetMijnVerenigingen(request);
		}

		public Task<GetMijnVerenigingenResponse> GetMijnVerenigingenAsync(GetMijnVerenigingenRequest request)
		{
			return LedenadministratieService.GetMijnVerenigingenAsync(request);
		}

		public GetNationaliteitenResponse GetNationaliteiten(GetNationaliteitenRequest request)
		{
			return LedenadministratieService.GetNationaliteiten(request);
		}

		public Task<GetNationaliteitenResponse> GetNationaliteitenAsync(GetNationaliteitenRequest request)
		{
			return LedenadministratieService.GetNationaliteitenAsync(request);
		}

		public GetOrganisatieResponse GetOrganisatie(GetOrganisatieRequest request)
		{
			return LedenadministratieService.GetOrganisatie(request);
		}

		public Task<GetOrganisatieResponse> GetOrganisatieAsync(GetOrganisatieRequest request)
		{
			return LedenadministratieService.GetOrganisatieAsync(request);
		}

		public GetPersoonsgegevensResponse GetPersoonsgegevens(GetPersoonsgegevensRequest request)
		{
			return LedenadministratieService.GetPersoonsgegevens(request);
		}

		public Task<GetPersoonsgegevensResponse> GetPersoonsgegevensAsync(GetPersoonsgegevensRequest request)
		{
			return LedenadministratieService.GetPersoonsgegevensAsync(request);
		}

		public GetPostcodeDetailResponse GetPostcodeDetail(GetPostcodeDetailRequest detailRequest)
		{
			return LedenadministratieService.GetPostcodeDetail(detailRequest);
		}

		public Task<GetPostcodeDetailResponse> GetPostcodeDetailAsync(GetPostcodeDetailRequest detailRequest)
		{
			return LedenadministratieService.GetPostcodeDetailAsync(detailRequest);
		}

		public GetSoortAbonneesResponse GetSoortAbonnees(GetSoortAbonneesRequest request)
		{
			return LedenadministratieService.GetSoortAbonnees(request);
		}

		public Task<GetSoortAbonneesResponse> GetSoortAbonneesAsync(GetSoortAbonneesRequest request)
		{
			return LedenadministratieService.GetSoortAbonneesAsync(request);
		}

		public GetSpelersprofielResponse GetSpelersprofiel(GetSpelersprofielRequest request)
		{
			return LedenadministratieService.GetSpelersprofiel(request);
		}

		public Task<GetSpelersprofielResponse> GetSpelersprofielAsync(GetSpelersprofielRequest request)
		{
			return LedenadministratieService.GetSpelersprofielAsync(request);
		}

		public GetSpelersProfielDetailResponse GetSpelersProfielDetail(GetSpelersProfielDetailRequest detailRequest)
		{
			return LedenadministratieService.GetSpelersProfielDetail(detailRequest);
		}

		public Task<GetSpelersProfielDetailResponse> GetSpelersProfielDetailAsync(GetSpelersProfielDetailRequest detailRequest)
		{
			return LedenadministratieService.GetSpelersProfielDetailAsync(detailRequest);
		}

		public GetToernooienForVerenigingResponse GetToernooienForVereniging(GetToernooienForVerenigingRequest request)
		{
			return LedenadministratieService.GetToernooienForVereniging(request);
		}

		public Task<GetToernooienForVerenigingResponse> GetToernooienForVerenigingAsync(GetToernooienForVerenigingRequest request)
		{
			return LedenadministratieService.GetToernooienForVerenigingAsync(request);
		}

		public GetToernooiResultatenResponse GetToernooiresultaten(GetToernooiresultatenRequest request)
		{
			return LedenadministratieService.GetToernooiresultaten(request);
		}

		public Task<GetToernooiResultatenResponse> GetToernooiresultatenAsync(GetToernooiresultatenRequest request)
		{
			return LedenadministratieService.GetToernooiresultatenAsync(request);
		}

		public GetUserDistrictResponse GetUserDistrict(GetUserDistrictRequest request)
		{
			return LedenadministratieService.GetUserDistrict(request);
		}

		public Task<GetUserDistrictResponse> GetUserDistrictAsync(GetUserDistrictRequest request)
		{
			return LedenadministratieService.GetUserDistrictAsync(request);
		}

		public GetVerenigingResponse GetVereniging(GetVerenigingRequest request)
		{
			return LedenadministratieService.GetVereniging(request);
		}

		public Task<GetVerenigingResponse> GetVerenigingAsync(GetVerenigingRequest request)
		{
			return LedenadministratieService.GetVerenigingAsync(request);
		}

		public GetVerenigingDataResponse GetVerenigingData(GetVerenigingDataRequest request)
		{
			return LedenadministratieService.GetVerenigingData(request);
		}

		public Task<GetVerenigingDataResponse> GetVerenigingDataAsync(GetVerenigingDataRequest request)
		{
			return LedenadministratieService.GetVerenigingDataAsync(request);
		}

		public HandleAanmakenBijwerkenWachtwoordResponse HandleAanmakenBijwerkenWachtwoord(HandleAanmakenBijwerkenWachtwoordRequest request)
		{
			return LedenadministratieService.HandleAanmakenBijwerkenWachtwoord(request);
		}

		public Task<HandleAanmakenBijwerkenWachtwoordResponse> HandleAanmakenBijwerkenWachtwoordAsync(HandleAanmakenBijwerkenWachtwoordRequest request)
		{
			return LedenadministratieService.HandleAanmakenBijwerkenWachtwoordAsync(request);
		}

		public HandleAbonneesResponse HandleAbonnees(HandleAbonneesRequest request)
		{
			return LedenadministratieService.HandleAbonnees(request);
		}

		public Task<HandleAbonneesResponse> HandleAbonneesAsync(HandleAbonneesRequest request)
		{
			return LedenadministratieService.HandleAbonneesAsync(request);
		}

		public HandleDuplicatenPersonenResponse HandleDuplicatenPersonen(HandleDuplicatenPersonenRequest request)
		{
			return LedenadministratieService.HandleDuplicatenPersonen(request);
		}

		public Task<HandleDuplicatenPersonenResponse> HandleDuplicatenPersonenAsync(HandleDuplicatenPersonenRequest request)
		{
			return LedenadministratieService.HandleDuplicatenPersonenAsync(request);
		}

		public HandleIdealPaymentResponse HandleIdealPayment(HandleIdealPaymentRequest request)
		{
			return LedenadministratieService.HandleIdealPayment(request);
		}

		public Task<HandleIdealPaymentResponse> HandleIdealPaymentAsync(HandleIdealPaymentRequest request)
		{
			return LedenadministratieService.HandleIdealPaymentAsync(request);
		}

		public HandleIdealPaymentCanceledResponse HandleIdealPaymentCanceled(HandleIdealPaymentCanceledRequest request)
		{
			return LedenadministratieService.HandleIdealPaymentCanceled(request);
		}

		public Task<HandleIdealPaymentCanceledResponse> HandleIdealPaymentCanceledAsync(HandleIdealPaymentCanceledRequest request)
		{
			return LedenadministratieService.HandleIdealPaymentCanceledAsync(request);
		}

		public HandleNietKNLTBResponse HandleNietKNLTB(HandleNietKNLTBRequest request)
		{
			return LedenadministratieService.HandleNietKNLTB(request);
		}

		public Task<HandleNietKNLTBResponse> HandleNietKNLTBAsync(HandleNietKNLTBRequest request)
		{
			return LedenadministratieService.HandleNietKNLTBAsync(request);
		}

		public SaveSpelersprofielResponse SaveSpelersprofiel(SaveSpelersprofielRequest request)
		{
			return LedenadministratieService.SaveSpelersprofiel(request);
		}

		public Task<SaveSpelersprofielResponse> SaveSpelersprofielAsync(SaveSpelersprofielRequest request)
		{
			return LedenadministratieService.SaveSpelersprofielAsync(request);
		}

		public GetMedelidResponse ZoekMedelid(GetMedelidRequest request)
		{
			return LedenadministratieService.ZoekMedelid(request);
		}

		public Task<GetMedelidResponse> ZoekMedelidAsync(GetMedelidRequest request)
		{
			return LedenadministratieService.ZoekMedelidAsync(request);
		}

		public ZoekPersoonResponse ZoekPersoon(ZoekPersoonRequest request)
		{
			return LedenadministratieService.ZoekPersoon(request);
		}

		public Task<ZoekPersoonResponse> ZoekPersoonAsync(ZoekPersoonRequest request)
		{
			return LedenadministratieService.ZoekPersoonAsync(request);
		}

		public ZoekSpelersProfielenResponse ZoekSpelersProfielen(ZoekSpelersProfielenRequest request)
		{
			return LedenadministratieService.ZoekSpelersProfielen(request);
		}

		public Task<ZoekSpelersProfielenResponse> ZoekSpelersProfielenAsync(ZoekSpelersProfielenRequest request)
		{
			return LedenadministratieService.ZoekSpelersProfielenAsync(request);
		}

		public ZoekVerenigingResponse ZoekVereniging(ZoekVerenigingRequest request)
		{
			return LedenadministratieService.ZoekVereniging(request);
		}

		public Task<ZoekVerenigingResponse> ZoekVerenigingAsync(ZoekVerenigingRequest request)
		{
			return LedenadministratieService.ZoekVerenigingAsync(request);
		}

		public ZoekVerenigingenResponse ZoekVerenigingen(ZoekVerenigingenRequest request)
		{
			return LedenadministratieService.ZoekVerenigingen(request);
		}

		public Task<ZoekVerenigingenResponse> ZoekVerenigingenAsync(ZoekVerenigingenRequest request)
		{
			return LedenadministratieService.ZoekVerenigingenAsync(request);
		}
	}
}