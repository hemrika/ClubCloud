using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[GeneratedCode("System.ServiceModel", "4.0.0.0")]
	[ServiceContract(Namespace="http://knltb.nl/services", ConfigurationName="ClubCloud.KNLTB.Servit.CompetitieService.ICompetitieService")]
	public interface ICompetitieService
	{
		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetAfdelingen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetAfdelingenResponse")]
		GetAfdelingenResponse GetAfdelingen(GetAfdelingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetAfdelingen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetAfdelingenResponse")]
		Task<GetAfdelingenResponse> GetAfdelingenAsync(GetAfdelingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetCompetities", ReplyAction="http://knltb.nl/services/ICompetitieService/GetCompetitiesResponse")]
		GetCompetitiesResponse GetCompetities(GetCompetitiesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetCompetities", ReplyAction="http://knltb.nl/services/ICompetitieService/GetCompetitiesResponse")]
		Task<GetCompetitiesResponse> GetCompetitiesAsync(GetCompetitiesRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetCompetitiesForInschrijving", ReplyAction="http://knltb.nl/services/ICompetitieService/GetCompetitiesForInschrijvingResponse")]
		GetCompetitiesForInschrijvingResponse GetCompetitiesForInschrijving(GetCompetitiesForInschrijvingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetCompetitiesForInschrijving", ReplyAction="http://knltb.nl/services/ICompetitieService/GetCompetitiesForInschrijvingResponse")]
		Task<GetCompetitiesForInschrijvingResponse> GetCompetitiesForInschrijvingAsync(GetCompetitiesForInschrijvingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetKlassengroepen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetKlassengroepenResponse")]
		GetKlassengroepenResponse GetKlassengroepen(GetKlassengroepenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetKlassengroepen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetKlassengroepenResponse")]
		Task<GetKlassengroepenResponse> GetKlassengroepenAsync(GetKlassengroepenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetKlassengroepenForInschrijving", ReplyAction="http://knltb.nl/services/ICompetitieService/GetKlassengroepenForInschrijvingResponse")]
		GetKlassengroepenForInschrijvingResponse GetKlassengroepenForInschrijving(GetKlassengroepenForInschrijvingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetKlassengroepenForInschrijving", ReplyAction="http://knltb.nl/services/ICompetitieService/GetKlassengroepenForInschrijvingResponse")]
		Task<GetKlassengroepenForInschrijvingResponse> GetKlassengroepenForInschrijvingAsync(GetKlassengroepenForInschrijvingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetPartijresultaten", ReplyAction="http://knltb.nl/services/ICompetitieService/GetPartijresultatenResponse")]
		GetPartijresultatenResponse GetPartijresultaten(GetPartijresultatenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetPartijresultaten", ReplyAction="http://knltb.nl/services/ICompetitieService/GetPartijresultatenResponse")]
		Task<GetPartijresultatenResponse> GetPartijresultatenAsync(GetPartijresultatenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetPloegen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetPloegenResponse")]
		GetPloegenResponse GetPloegen(GetPloegenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetPloegen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetPloegenResponse")]
		Task<GetPloegenResponse> GetPloegenAsync(GetPloegenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetStanden", ReplyAction="http://knltb.nl/services/ICompetitieService/GetStandenResponse")]
		GetStandenResponse GetStanden(GetStandenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetStanden", ReplyAction="http://knltb.nl/services/ICompetitieService/GetStandenResponse")]
		Task<GetStandenResponse> GetStandenAsync(GetStandenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetUitslagenAfdeling", ReplyAction="http://knltb.nl/services/ICompetitieService/GetUitslagenAfdelingResponse")]
		GetUitslagenAfdelingResponse GetUitslagenAfdeling(GetUitslagenAfdelingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetUitslagenAfdeling", ReplyAction="http://knltb.nl/services/ICompetitieService/GetUitslagenAfdelingResponse")]
		Task<GetUitslagenAfdelingResponse> GetUitslagenAfdelingAsync(GetUitslagenAfdelingRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetVerenigingen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetVerenigingenResponse")]
		GetVerenigingenResponse GetVerenigingen(GetVerenigingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetVerenigingen", ReplyAction="http://knltb.nl/services/ICompetitieService/GetVerenigingenResponse")]
		Task<GetVerenigingenResponse> GetVerenigingenAsync(GetVerenigingenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetWedstrijdgegevens", ReplyAction="http://knltb.nl/services/ICompetitieService/GetWedstrijdgegevensResponse")]
		GetWedstrijdgegevensResponse GetWedstrijdgegevens(GetWedstrijdgegevensRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/GetWedstrijdgegevens", ReplyAction="http://knltb.nl/services/ICompetitieService/GetWedstrijdgegevensResponse")]
		Task<GetWedstrijdgegevensResponse> GetWedstrijdgegevensAsync(GetWedstrijdgegevensRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/ZoekIngedeeldePloegen", ReplyAction="http://knltb.nl/services/ICompetitieService/ZoekIngedeeldePloegenResponse")]
		ZoekIngedeeldePloegenResponse ZoekIngedeeldePloegen(ZoekIngedeeldePloegenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/ZoekIngedeeldePloegen", ReplyAction="http://knltb.nl/services/ICompetitieService/ZoekIngedeeldePloegenResponse")]
		Task<ZoekIngedeeldePloegenResponse> ZoekIngedeeldePloegenAsync(ZoekIngedeeldePloegenRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/ZoekWedstrijdgegevens", ReplyAction="http://knltb.nl/services/ICompetitieService/ZoekWedstrijdgegevensResponse")]
		ZoekWedstrijdgegevensResponse ZoekWedstrijdgegevens(ZoekWedstrijdgegevensRequest request);

		[OperationContract(Action="http://knltb.nl/services/ICompetitieService/ZoekWedstrijdgegevens", ReplyAction="http://knltb.nl/services/ICompetitieService/ZoekWedstrijdgegevensResponse")]
		Task<ZoekWedstrijdgegevensResponse> ZoekWedstrijdgegevensAsync(ZoekWedstrijdgegevensRequest request);
	}
}