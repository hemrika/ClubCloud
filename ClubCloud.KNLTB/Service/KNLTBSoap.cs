using ClubCloud.KNLTB.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    [System.ServiceModel.ServiceContractAttribute()]
    internal interface KNLTBSoap
    {
        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSpelersprofielTotaal", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        SpelersprofielTotaal GetSpelersprofielTotaal(string enc, string bondnumber, System.DateTime dateFrom);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSpelersprofielTotaal", ReplyAction = "*")]
        System.Threading.Tasks.Task<SpelersprofielTotaal> GetSpelersprofielTotaalAsync(string enc, string bondnumber, System.DateTime dateFrom);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPersoonByName", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        ZoekPersoon[] GetPersoonByName(string enc, string naam, string organisatienaam);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPersoonByName", ReplyAction = "*")]
        System.Threading.Tasks.Task<ZoekPersoon[]> GetPersoonByNameAsync(string enc, string naam, string organisatienaam);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSlideShow", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        SlideShowItem[] GetSlideShow();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSlideShow", ReplyAction = "*")]
        System.Threading.Tasks.Task<SlideShowItem[]> GetSlideShowAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPlayersProfileShort", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Spelersprofiel GetPlayersProfileShort(string enc, string bondnumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPlayersProfileShort", ReplyAction = "*")]
        System.Threading.Tasks.Task<Spelersprofiel> GetPlayersProfileShortAsync(string enc, string bondnumber);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPlayersProfileShortList", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Spelersprofiel[] GetPlayersProfileShortList(string enc, string[] bondnumbersArray);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPlayersProfileShortList", ReplyAction = "*")]
        System.Threading.Tasks.Task<Spelersprofiel[]> GetPlayersProfileShortListAsync(string enc, string[] bondnumbersArray);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_Login", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        string MK_Login(string enc, string bondsnummer, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_Login", ReplyAction = "*")]
        System.Threading.Tasks.Task<string> MK_LoginAsync(string enc, string bondsnummer, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetSuggestedTeams", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        MKTeam[] MK_GetSuggestedTeams(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetSuggestedTeams", ReplyAction = "*")]
        System.Threading.Tasks.Task<MKTeam[]> MK_GetSuggestedTeamsAsync(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetWedstrijdKalender", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        CalWedstrijd[] MK_GetWedstrijdKalender(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetWedstrijdKalender", ReplyAction = "*")]
        System.Threading.Tasks.Task<CalWedstrijd[]> MK_GetWedstrijdKalenderAsync(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPouleStanden", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        PouleStanden[] GetPouleStanden(string enc, System.Guid pouleId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPouleStanden", ReplyAction = "*")]
        System.Threading.Tasks.Task<PouleStanden[]> GetPouleStandenAsync(string enc, System.Guid pouleId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetWedstrijdPartijResults", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        PartijResult[] GetWedstrijdPartijResults(string enc, System.Guid wedstrijdId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetWedstrijdPartijResults", ReplyAction = "*")]
        System.Threading.Tasks.Task<PartijResult[]> GetWedstrijdPartijResultsAsync(string enc, System.Guid wedstrijdId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPouleWedstrijden", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        PouleWedstrijd[] GetPouleWedstrijden(string enc, System.Guid pouleId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPouleWedstrijden", ReplyAction = "*")]
        System.Threading.Tasks.Task<PouleWedstrijd[]> GetPouleWedstrijdenAsync(string enc, System.Guid pouleId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPasfoto", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Pasfoto GetPasfoto(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPasfoto", ReplyAction = "*")]
        System.Threading.Tasks.Task<Pasfoto> GetPasfotoAsync(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/SetPhotoShared", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        void SetPhotoShared(string enc, string persoonId, bool shared);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/SetPhotoShared", ReplyAction = "*")]
        System.Threading.Tasks.Task SetPhotoSharedAsync(string enc, string persoonId, bool shared);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPhotoShared", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        bool GetPhotoShared(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetPhotoShared", ReplyAction = "*")]
        System.Threading.Tasks.Task<bool> GetPhotoSharedAsync(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetMijnTeams", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        MKTeam[] MK_GetMijnTeams(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_GetMijnTeams", ReplyAction = "*")]
        System.Threading.Tasks.Task<MKTeam[]> MK_GetMijnTeamsAsync(string enc, string persoonId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_AddTeam", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        void MK_AddTeam(string enc, string persoonId, System.Guid teamId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_AddTeam", ReplyAction = "*")]
        System.Threading.Tasks.Task MK_AddTeamAsync(string enc, string persoonId, System.Guid teamId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_DeleteTeam", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        void MK_DeleteTeam(string enc, string persoonId, System.Guid teamId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/MK_DeleteTeam", ReplyAction = "*")]
        System.Threading.Tasks.Task MK_DeleteTeamAsync(string enc, string persoonId, System.Guid teamId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSpelersPas", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        SpelersPas GetSpelersPas(string enc, string bondsnummer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetSpelersPas", ReplyAction = "*")]
        System.Threading.Tasks.Task<SpelersPas> GetSpelersPasAsync(string enc, string bondsnummer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetVerenigingen", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Vereniging[] GetVerenigingen(string enc, string plaats, string verenigingsnummer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetVerenigingen", ReplyAction = "*")]
        System.Threading.Tasks.Task<Vereniging[]> GetVerenigingenAsync(string enc, string plaats, string verenigingsnummer);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetTeams", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Team[] GetTeams(System.Guid verenigingsId, System.Guid competitieId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetTeams", ReplyAction = "*")]
        System.Threading.Tasks.Task<Team[]> GetTeamsAsync(System.Guid verenigingsId, System.Guid competitieId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetCompetities", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Competitie[] GetCompetities();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetCompetities", ReplyAction = "*")]
        System.Threading.Tasks.Task<Competitie[]> GetCompetitiesAsync();

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetVerenigingenByCompetitie", ReplyAction = "*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults = true)]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Wedstrijd))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Persoon))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Speler))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(Partij))]
        Vereniging[] GetVerenigingenByCompetitie(System.Guid competitieId);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/GetVerenigingenByCompetitie", ReplyAction = "*")]
        System.Threading.Tasks.Task<Vereniging[]> GetVerenigingenByCompetitieAsync(System.Guid competitieId);
    }
}
