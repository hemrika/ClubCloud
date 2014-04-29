using ClubCloud.KNLTB.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB.Service
{
    internal partial class KNLTBSoapClient : System.ServiceModel.ClientBase<KNLTBSoap>, KNLTBSoap
    {

        internal KNLTBSoapClient()
        {
        }

        internal KNLTBSoapClient(KNLTBBinding binding, KNLTBEndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        protected override KNLTBSoap CreateChannel()
        {
            return base.CreateChannel();
        }

        public SpelersprofielTotaal GetSpelersprofielTotaal(string enc, string bondnumber, System.DateTime dateFrom)
        {
            return base.Channel.GetSpelersprofielTotaal(enc, bondnumber, dateFrom);
        }

        public System.Threading.Tasks.Task<SpelersprofielTotaal> GetSpelersprofielTotaalAsync(string enc, string bondnumber, System.DateTime dateFrom)
        {
            return base.Channel.GetSpelersprofielTotaalAsync(enc, bondnumber, dateFrom);
        }

        public ZoekPersoon[] GetPersoonByName(string enc, string naam, string organisatienaam)
        {
            return base.Channel.GetPersoonByName(enc, naam, organisatienaam);
        }

        public System.Threading.Tasks.Task<ZoekPersoon[]> GetPersoonByNameAsync(string enc, string naam, string organisatienaam)
        {
            return base.Channel.GetPersoonByNameAsync(enc, naam, organisatienaam);
        }

        public SlideShowItem[] GetSlideShow()
        {
            return base.Channel.GetSlideShow();
        }

        public System.Threading.Tasks.Task<SlideShowItem[]> GetSlideShowAsync()
        {
            return base.Channel.GetSlideShowAsync();
        }

        public Spelersprofiel GetPlayersProfileShort(string enc, string bondnumber)
        {
            return base.Channel.GetPlayersProfileShort(enc, bondnumber);
        }

        public System.Threading.Tasks.Task<Spelersprofiel> GetPlayersProfileShortAsync(string enc, string bondnumber)
        {
            return base.Channel.GetPlayersProfileShortAsync(enc, bondnumber);
        }

        public Spelersprofiel[] GetPlayersProfileShortList(string enc, string[] bondnumbersArray)
        {
            return base.Channel.GetPlayersProfileShortList(enc, bondnumbersArray);
        }

        public System.Threading.Tasks.Task<Spelersprofiel[]> GetPlayersProfileShortListAsync(string enc, string[] bondnumbersArray)
        {
            return base.Channel.GetPlayersProfileShortListAsync(enc, bondnumbersArray);
        }

        public string MK_Login(string enc, string bondsnummer, string password)
        {
            return base.Channel.MK_Login(enc, bondsnummer, password);
        }

        public System.Threading.Tasks.Task<string> MK_LoginAsync(string enc, string bondsnummer, string password)
        {
            return base.Channel.MK_LoginAsync(enc, bondsnummer, password);
        }

        public MKTeam[] MK_GetSuggestedTeams(string enc, string persoonId)
        {
            return base.Channel.MK_GetSuggestedTeams(enc, persoonId);
        }

        public System.Threading.Tasks.Task<MKTeam[]> MK_GetSuggestedTeamsAsync(string enc, string persoonId)
        {
            return base.Channel.MK_GetSuggestedTeamsAsync(enc, persoonId);
        }

        public CalWedstrijd[] MK_GetWedstrijdKalender(string enc, string persoonId)
        {
            return base.Channel.MK_GetWedstrijdKalender(enc, persoonId);
        }

        public System.Threading.Tasks.Task<CalWedstrijd[]> MK_GetWedstrijdKalenderAsync(string enc, string persoonId)
        {
            return base.Channel.MK_GetWedstrijdKalenderAsync(enc, persoonId);
        }

        public PouleStanden[] GetPouleStanden(string enc, System.Guid pouleId)
        {
            return base.Channel.GetPouleStanden(enc, pouleId);
        }

        public System.Threading.Tasks.Task<PouleStanden[]> GetPouleStandenAsync(string enc, System.Guid pouleId)
        {
            return base.Channel.GetPouleStandenAsync(enc, pouleId);
        }

        public PartijResult[] GetWedstrijdPartijResults(string enc, System.Guid wedstrijdId)
        {
            return base.Channel.GetWedstrijdPartijResults(enc, wedstrijdId);
        }

        public System.Threading.Tasks.Task<PartijResult[]> GetWedstrijdPartijResultsAsync(string enc, System.Guid wedstrijdId)
        {
            return base.Channel.GetWedstrijdPartijResultsAsync(enc, wedstrijdId);
        }

        public PouleWedstrijd[] GetPouleWedstrijden(string enc, System.Guid pouleId)
        {
            return base.Channel.GetPouleWedstrijden(enc, pouleId);
        }

        public System.Threading.Tasks.Task<PouleWedstrijd[]> GetPouleWedstrijdenAsync(string enc, System.Guid pouleId)
        {
            return base.Channel.GetPouleWedstrijdenAsync(enc, pouleId);
        }

        public Pasfoto GetPasfoto(string enc, string persoonId)
        {
            return base.Channel.GetPasfoto(enc, persoonId);
        }

        public System.Threading.Tasks.Task<Pasfoto> GetPasfotoAsync(string enc, string persoonId)
        {
            return base.Channel.GetPasfotoAsync(enc, persoonId);
        }

        public void SetPhotoShared(string enc, string persoonId, bool shared)
        {
            base.Channel.SetPhotoShared(enc, persoonId, shared);
        }

        public System.Threading.Tasks.Task SetPhotoSharedAsync(string enc, string persoonId, bool shared)
        {
            return base.Channel.SetPhotoSharedAsync(enc, persoonId, shared);
        }

        public bool GetPhotoShared(string enc, string persoonId)
        {
            return base.Channel.GetPhotoShared(enc, persoonId);
        }

        public System.Threading.Tasks.Task<bool> GetPhotoSharedAsync(string enc, string persoonId)
        {
            return base.Channel.GetPhotoSharedAsync(enc, persoonId);
        }

        public MKTeam[] MK_GetMijnTeams(string enc, string persoonId)
        {
            return base.Channel.MK_GetMijnTeams(enc, persoonId);
        }

        public System.Threading.Tasks.Task<MKTeam[]> MK_GetMijnTeamsAsync(string enc, string persoonId)
        {
            return base.Channel.MK_GetMijnTeamsAsync(enc, persoonId);
        }

        public void MK_AddTeam(string enc, string persoonId, System.Guid teamId)
        {
            base.Channel.MK_AddTeam(enc, persoonId, teamId);
        }

        public System.Threading.Tasks.Task MK_AddTeamAsync(string enc, string persoonId, System.Guid teamId)
        {
            return base.Channel.MK_AddTeamAsync(enc, persoonId, teamId);
        }

        public void MK_DeleteTeam(string enc, string persoonId, System.Guid teamId)
        {
            base.Channel.MK_DeleteTeam(enc, persoonId, teamId);
        }

        public System.Threading.Tasks.Task MK_DeleteTeamAsync(string enc, string persoonId, System.Guid teamId)
        {
            return base.Channel.MK_DeleteTeamAsync(enc, persoonId, teamId);
        }

        public SpelersPas GetSpelersPas(string enc, string bondsnummer)
        {
            return base.Channel.GetSpelersPas(enc, bondsnummer);
        }

        public System.Threading.Tasks.Task<SpelersPas> GetSpelersPasAsync(string enc, string bondsnummer)
        {
            return base.Channel.GetSpelersPasAsync(enc, bondsnummer);
        }

        public Vereniging[] GetVerenigingen(string enc, string plaats, string verenigingsnummer)
        {
            return base.Channel.GetVerenigingen(enc, plaats, verenigingsnummer);
        }

        public System.Threading.Tasks.Task<Vereniging[]> GetVerenigingenAsync(string enc, string plaats, string verenigingsnummer)
        {
            return base.Channel.GetVerenigingenAsync(enc, plaats, verenigingsnummer);
        }

        public Team[] GetTeams(System.Guid verenigingsId, System.Guid competitieId)
        {
            return base.Channel.GetTeams(verenigingsId, competitieId);
        }

        public System.Threading.Tasks.Task<Team[]> GetTeamsAsync(System.Guid verenigingsId, System.Guid competitieId)
        {
            return base.Channel.GetTeamsAsync(verenigingsId, competitieId);
        }

        public Competitie[] GetCompetities()
        {
            return base.Channel.GetCompetities();
        }

        public System.Threading.Tasks.Task<Competitie[]> GetCompetitiesAsync()
        {
            return base.Channel.GetCompetitiesAsync();
        }

        public Vereniging[] GetVerenigingenByCompetitie(System.Guid competitieId)
        {
            return base.Channel.GetVerenigingenByCompetitie(competitieId);
        }

        public System.Threading.Tasks.Task<Vereniging[]> GetVerenigingenByCompetitieAsync(System.Guid competitieId)
        {
            return base.Channel.GetVerenigingenByCompetitieAsync(competitieId);
        }
    }
}
