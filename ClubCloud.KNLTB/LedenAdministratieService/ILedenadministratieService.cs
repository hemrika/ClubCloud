using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace="http://knltb.nl/services", ConfigurationName="ClubCloud.KNLTB.Servit.LedenAdministratieService.ILedenadministratieService")]
	public interface ILedenadministratieService
	{
		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealEventsPayment", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealEventsPaymentResponse")]
		CreateIdealPaymentResponse CreateIdealEventsPayment(CreateIdealEventsPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealEventsPayment", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealEventsPaymentResponse")]
		Task<CreateIdealPaymentResponse> CreateIdealEventsPaymentAsync(CreateIdealEventsPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealPayment", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealPaymentResponse")]
		CreateIdealPaymentResponse CreateIdealPayment(CreateIdealPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealPayment", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealPaymentResponse")]
		Task<CreateIdealPaymentResponse> CreateIdealPaymentAsync(CreateIdealPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealPaymentControl", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealPaymentControlResponse")]
		CreateIdealPaymentControlResponse CreateIdealPaymentControl(CreateIdealPaymentControlRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/CreateIdealPaymentControl", ReplyAction="http://knltb.nl/services/IIdealService/CreateIdealPaymentControlResponse")]
		Task<CreateIdealPaymentControlResponse> CreateIdealPaymentControlAsync(CreateIdealPaymentControlRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatie", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieResponse")]
		GetAccommodatieResponse GetAccommodatie(GetAccommodatieRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatie", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieResponse")]
		Task<GetAccommodatieResponse> GetAccommodatieAsync(GetAccommodatieRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieForVerenigingResponse")]
		GetAccommodatieForVerenigingResponse GetAccommodatieForVereniging(GetAccommodatieForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetAccommodatieForVerenigingResponse")]
		Task<GetAccommodatieForVerenigingResponse> GetAccommodatieForVerenigingAsync(GetAccommodatieForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForSpecifiek", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForSpecifiekResponse")]
		GetBasisOrganisatieForSpecifiekResponse GetBasisOrganisatieForSpecifiek(GetBasisOrganisatieForSpecifiekRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForSpecifiek", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForSpecifiekResponse")]
		Task<GetBasisOrganisatieForSpecifiekResponse> GetBasisOrganisatieForSpecifiekAsync(GetBasisOrganisatieForSpecifiekRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForType", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForTypeResponse")]
		GetBasisOrganisatieForTypeResponse GetBasisOrganisatieForType(GetBasisOrganisatieForTypeRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForType", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieForTypeResponse")]
		Task<GetBasisOrganisatieForTypeResponse> GetBasisOrganisatieForTypeAsync(GetBasisOrganisatieForTypeRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieLandelijk", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieLandelijkResponse")]
		GetBasisOrganisatieLandelijkResponse GetBasisOrganisatieLandelijk(GetBasisOrganisatieLandelijkRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieLandelijk", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisOrganisatieLandelijkResponse")]
		Task<GetBasisOrganisatieLandelijkResponse> GetBasisOrganisatieLandelijkAsync(GetBasisOrganisatieLandelijkRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisorganisaties", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisorganisatiesResponse")]
		GetBasisorganisatiesResponse GetBasisorganisaties(GetBasisorganisatiesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisorganisaties", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBasisorganisatiesResponse")]
		Task<GetBasisorganisatiesResponse> GetBasisorganisatiesAsync(GetBasisorganisatiesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBestuursorganenForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBestuursorganenForVerenigingResponse")]
		GetBestuursorganenForVerenigingResponse GetBestuursorganenForVereniging(GetBestuursorganenForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBestuursorganenForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetBestuursorganenForVerenigingResponse")]
		Task<GetBestuursorganenForVerenigingResponse> GetBestuursorganenForVerenigingAsync(GetBestuursorganenForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetCompetitiesForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetCompetitiesForVerenigingResponse")]
		GetCompetitiesForVerenigingResponse GetCompetitiesForVereniging(GetCompetitiesForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetCompetitiesForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetCompetitiesForVerenigingResponse")]
		Task<GetCompetitiesForVerenigingResponse> GetCompetitiesForVerenigingAsync(GetCompetitiesForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetDistrict", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetDistrictResponse")]
		GetDistrictResponse GetDistrict(GetDistrictRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetDistrict", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetDistrictResponse")]
		Task<GetDistrictResponse> GetDistrictAsync(GetDistrictRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetMijnVerenigingen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetMijnVerenigingenResponse")]
		GetMijnVerenigingenResponse GetMijnVerenigingen(GetMijnVerenigingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetMijnVerenigingen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetMijnVerenigingenResponse")]
		Task<GetMijnVerenigingenResponse> GetMijnVerenigingenAsync(GetMijnVerenigingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetNationaliteiten", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetNationaliteitenResponse")]
		GetNationaliteitenResponse GetNationaliteiten(GetNationaliteitenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetNationaliteiten", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetNationaliteitenResponse")]
		Task<GetNationaliteitenResponse> GetNationaliteitenAsync(GetNationaliteitenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetOrganisatie", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetOrganisatieResponse")]
		GetOrganisatieResponse GetOrganisatie(GetOrganisatieRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetOrganisatie", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetOrganisatieResponse")]
		Task<GetOrganisatieResponse> GetOrganisatieAsync(GetOrganisatieRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPersoonsgegevens", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPersoonsgegevensResponse")]
		GetPersoonsgegevensResponse GetPersoonsgegevens(GetPersoonsgegevensRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPersoonsgegevens", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPersoonsgegevensResponse")]
		Task<GetPersoonsgegevensResponse> GetPersoonsgegevensAsync(GetPersoonsgegevensRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPostcodeDetail", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPostcodeDetailResponse")]
		GetPostcodeDetailResponse GetPostcodeDetail(GetPostcodeDetailRequest detailRequest);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPostcodeDetail", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetPostcodeDetailResponse")]
		Task<GetPostcodeDetailResponse> GetPostcodeDetailAsync(GetPostcodeDetailRequest detailRequest);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSoortAbonnees", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSoortAbonneesResponse")]
		GetSoortAbonneesResponse GetSoortAbonnees(GetSoortAbonneesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSoortAbonnees", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSoortAbonneesResponse")]
		Task<GetSoortAbonneesResponse> GetSoortAbonneesAsync(GetSoortAbonneesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersprofiel", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersprofielResponse")]
		GetSpelersprofielResponse GetSpelersprofiel(GetSpelersprofielRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersprofiel", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersprofielResponse")]
		Task<GetSpelersprofielResponse> GetSpelersprofielAsync(GetSpelersprofielRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersProfielDetail", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersProfielDetailResponse")]
		GetSpelersProfielDetailResponse GetSpelersProfielDetail(GetSpelersProfielDetailRequest detailRequest);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersProfielDetail", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetSpelersProfielDetailResponse")]
		Task<GetSpelersProfielDetailResponse> GetSpelersProfielDetailAsync(GetSpelersProfielDetailRequest detailRequest);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooienForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooienForVerenigingResponse")]
		GetToernooienForVerenigingResponse GetToernooienForVereniging(GetToernooienForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooienForVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooienForVerenigingResponse")]
		Task<GetToernooienForVerenigingResponse> GetToernooienForVerenigingAsync(GetToernooienForVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooiresultaten", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooiresultatenResponse")]
		GetToernooiResultatenResponse GetToernooiresultaten(GetToernooiresultatenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooiresultaten", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetToernooiresultatenResponse")]
		Task<GetToernooiResultatenResponse> GetToernooiresultatenAsync(GetToernooiresultatenRequest request);

		[OperationContract(Action="http://knltb.nl/services/IRelatiebeheerService/GetUserDistrict", ReplyAction="http://knltb.nl/services/IRelatiebeheerService/GetUserDistrictResponse")]
		GetUserDistrictResponse GetUserDistrict(GetUserDistrictRequest request);

		[OperationContract(Action="http://knltb.nl/services/IRelatiebeheerService/GetUserDistrict", ReplyAction="http://knltb.nl/services/IRelatiebeheerService/GetUserDistrictResponse")]
		Task<GetUserDistrictResponse> GetUserDistrictAsync(GetUserDistrictRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetVerenigingResponse")]
		GetVerenigingResponse GetVereniging(GetVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/GetVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/GetVerenigingResponse")]
		Task<GetVerenigingResponse> GetVerenigingAsync(GetVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/IRelatiebeheerService/GetVerenigingData", ReplyAction="http://knltb.nl/services/IRelatiebeheerService/GetVerenigingDataResponse")]
		GetVerenigingDataResponse GetVerenigingData(GetVerenigingDataRequest request);

		[OperationContract(Action="http://knltb.nl/services/IRelatiebeheerService/GetVerenigingData", ReplyAction="http://knltb.nl/services/IRelatiebeheerService/GetVerenigingDataResponse")]
		Task<GetVerenigingDataResponse> GetVerenigingDataAsync(GetVerenigingDataRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAanmakenBijwerkenWachtwoord", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAanmakenBijwerkenWachtwoordResponse")]
		HandleAanmakenBijwerkenWachtwoordResponse HandleAanmakenBijwerkenWachtwoord(HandleAanmakenBijwerkenWachtwoordRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAanmakenBijwerkenWachtwoord", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAanmakenBijwerkenWachtwoordResponse")]
		Task<HandleAanmakenBijwerkenWachtwoordResponse> HandleAanmakenBijwerkenWachtwoordAsync(HandleAanmakenBijwerkenWachtwoordRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAbonnees", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAbonneesResponse")]
		HandleAbonneesResponse HandleAbonnees(HandleAbonneesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAbonnees", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleAbonneesResponse")]
		Task<HandleAbonneesResponse> HandleAbonneesAsync(HandleAbonneesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleDuplicatenPersonen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleDuplicatenPersonenResponse")]
		HandleDuplicatenPersonenResponse HandleDuplicatenPersonen(HandleDuplicatenPersonenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleDuplicatenPersonen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleDuplicatenPersonenResponse")]
		Task<HandleDuplicatenPersonenResponse> HandleDuplicatenPersonenAsync(HandleDuplicatenPersonenRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/HandleIdealPayment", ReplyAction="http://knltb.nl/services/IIdealService/HandleIdealPaymentResponse")]
		HandleIdealPaymentResponse HandleIdealPayment(HandleIdealPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/HandleIdealPayment", ReplyAction="http://knltb.nl/services/IIdealService/HandleIdealPaymentResponse")]
		Task<HandleIdealPaymentResponse> HandleIdealPaymentAsync(HandleIdealPaymentRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/HandleIdealPaymentCanceled", ReplyAction="http://knltb.nl/services/IIdealService/HandleIdealPaymentCanceledResponse")]
		HandleIdealPaymentCanceledResponse HandleIdealPaymentCanceled(HandleIdealPaymentCanceledRequest request);

		[OperationContract(Action="http://knltb.nl/services/IIdealService/HandleIdealPaymentCanceled", ReplyAction="http://knltb.nl/services/IIdealService/HandleIdealPaymentCanceledResponse")]
		Task<HandleIdealPaymentCanceledResponse> HandleIdealPaymentCanceledAsync(HandleIdealPaymentCanceledRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleNietKNLTB", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleNietKNLTBResponse")]
		HandleNietKNLTBResponse HandleNietKNLTB(HandleNietKNLTBRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleNietKNLTB", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/HandleNietKNLTBResponse")]
		Task<HandleNietKNLTBResponse> HandleNietKNLTBAsync(HandleNietKNLTBRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/SaveSpelersprofiel", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/SaveSpelersprofielResponse")]
		SaveSpelersprofielResponse SaveSpelersprofiel(SaveSpelersprofielRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/SaveSpelersprofiel", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/SaveSpelersprofielResponse")]
		Task<SaveSpelersprofielResponse> SaveSpelersprofielAsync(SaveSpelersprofielRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekMedelid", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekMedelidResponse")]
		GetMedelidResponse ZoekMedelid(GetMedelidRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekMedelid", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekMedelidResponse")]
		Task<GetMedelidResponse> ZoekMedelidAsync(GetMedelidRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekPersoon", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekPersoonResponse")]
		ZoekPersoonResponse ZoekPersoon(ZoekPersoonRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekPersoon", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekPersoonResponse")]
		Task<ZoekPersoonResponse> ZoekPersoonAsync(ZoekPersoonRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekSpelersProfielen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekSpelersProfielenResponse")]
		ZoekSpelersProfielenResponse ZoekSpelersProfielen(ZoekSpelersProfielenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekSpelersProfielen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekSpelersProfielenResponse")]
		Task<ZoekSpelersProfielenResponse> ZoekSpelersProfielenAsync(ZoekSpelersProfielenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingResponse")]
		ZoekVerenigingResponse ZoekVereniging(ZoekVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVereniging", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingResponse")]
		Task<ZoekVerenigingResponse> ZoekVerenigingAsync(ZoekVerenigingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingenResponse")]
		ZoekVerenigingenResponse ZoekVerenigingen(ZoekVerenigingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingen", ReplyAction="http://knltb.nl/services/ILedenadministratieServiceInternal/ZoekVerenigingenResponse")]
		Task<ZoekVerenigingenResponse> ZoekVerenigingenAsync(ZoekVerenigingenRequest request);
	}
}