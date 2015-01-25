using ClubCloud.KNLTB.Client;
using ClubCloud.KNLTB.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubCloud.KNLTB
{
    public class KNLTBService : System.ComponentModel.INotifyPropertyChanged, IDisposable
    {
        private static KNLTBBinding binding = new KNLTBBinding();

        private static KNLTBEndpointAddress remoteAddress { get; set; }

        private static string _serverNameClient;

        private static KNLTBSoapClient client = null;

        public static string ServerNameClient
        {
            get { return KNLTBService._serverNameClient; }
            set { KNLTBService._serverNameClient = value; }
        }
        public KNLTBService()
        {
            Connect();

        }

        private void Connect()
        {
            KNLTBService.ServerNameClient = "http://apps4us-knltb.nl//webserviceKNLTB.asmx";

            remoteAddress = new Service.KNLTBEndpointAddress(KNLTBService.ServerNameClient);

            client = new KNLTBSoapClient(binding, remoteAddress);
            
        }

        public List<Competitie> Competities()
        {
            List<Competitie> competities = new List<Competitie>();

            if(client != null)
            {
               competities= client.GetCompetities().ToList<Competitie>();
            }
            return competities;
        }

        public Spelersprofiel Spelersprofiel(string bondsnummer)
        {
            Spelersprofiel spelersprofiel = new Spelersprofiel();

            if (client != null)
            {
                spelersprofiel = client.GetPlayersProfileShort(string.Empty, bondsnummer);
            }

            return spelersprofiel;
        }

        public Spelersprofiel Spelersprofiel(string bondsnummer, DateTime dateFrom)
        {
            Spelersprofiel spelersprofiel = new Spelersprofiel();

            if (client != null)
            {
                spelersprofiel = client.GetSpelersprofielTotaal(string.Empty, bondsnummer,dateFrom).Spelersprofiel;
            }

            return spelersprofiel;
        }

        public void Spelersprofiel(ref Spelersprofiel profiel)
        {
            if (client != null && string.IsNullOrWhiteSpace(profiel.Bondsnummer.ToString()))
            {
                profiel = client.GetPlayersProfileShort(string.Empty, profiel.Bondsnummer.ToString());
            }
        }

        public List<Spelersprofiel> Spelersprofielen(string[] bondsnummer)
        {
            List<Spelersprofiel> spelersprofielen = new List<Spelersprofiel>();

            if (client != null)
            {
                spelersprofielen = client.GetPlayersProfileShortList(string.Empty, bondsnummer).ToList<Spelersprofiel>();
            }

            return spelersprofielen;
        }

        public List<Spelersprofiel> Spelersprofielen(List<string> bondsnummer)
        {
            List<Spelersprofiel> spelersprofielen = new List<Spelersprofiel>();

            if (client != null)
            {
                spelersprofielen = client.GetPlayersProfileShortList(string.Empty, bondsnummer.ToArray()).ToList<Spelersprofiel>();
            }

            return spelersprofielen;
        }

        public List<PartijResult> Competitie(string bondsnummer, DateTime dateFrom)
        {
            List<PartijResult> uitslagen = new List<PartijResult>();

            if (client != null)
            {
                uitslagen = client.GetSpelersprofielTotaal(string.Empty, bondsnummer, dateFrom).UitslagenCompetitie.ToList<PartijResult>();
            }

            return uitslagen;
        }

        public List<PartijResult> Toernooi(string bondsnummer, DateTime dateFrom)
        {
            List<PartijResult> uitslagen = new List<PartijResult>();

            if (client != null)
            {
                uitslagen = client.GetSpelersprofielTotaal(string.Empty, bondsnummer, dateFrom).UitslagenToernooien.ToList<PartijResult>();
            }

            return uitslagen;
        }

        public Pasfoto Pasfoto(string bondsnummer, DateTime dateFrom)
        {
            Pasfoto foto = new Pasfoto();

            if (client != null)
            {
                foto = client.GetPasfoto(string.Empty, bondsnummer);
            }

            return foto;
        }

        public List<PouleStanden> Poule(Guid pouleId)
        {
            List<PouleStanden> poule = new List<PouleStanden>();

            if (client != null)
            {
                poule = client.GetPouleStanden(string.Empty, pouleId).ToList<PouleStanden>();
            }

            return poule;
        }

        public List<PouleWedstrijd> Wedstrijden(Guid pouleId)
        {
            List<PouleWedstrijd> wedstrijden = new List<PouleWedstrijd>();

            if (client != null)
            {
                wedstrijden = client.GetPouleWedstrijden(string.Empty, pouleId).ToList<PouleWedstrijd>();
            }

            return wedstrijden;
        }

        public SpelersPas Pas(string bondsnummer)
        {
            SpelersPas pas = new SpelersPas();

            if (client != null)
            {
                pas = client.GetSpelersPas(string.Empty, bondsnummer);
            }

            return pas;
        }

        public List<Team> Teams(Guid vereigingsId, Guid competitieId)
        {
            List<Team> teams = new List<Team>();

            if (client != null)
            {
                teams = client.GetTeams(vereigingsId,competitieId).ToList<Team>();
            }

            return teams;
        }

        public List<Team> Teams(string verenigingsnummer, Guid competitieId)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();
            List<Team> teams = new List<Team>();

            if (client != null)
            {
                verenigingen = client.GetVerenigingen(string.Empty, string.Empty, verenigingsnummer).ToList<Vereniging>();
            }
            Vereniging found = verenigingen.SingleOrDefault(v => v.Verenigingsnummer == verenigingsnummer);
            if(found != null)
            {
                return Teams(found.Id, competitieId);
            }
            return teams;
        }

        public Vereniging Vereniging(string verenigingsnummer)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();
            Vereniging vereniging = new Vereniging();

            if (client != null)
            {
                verenigingen = client.GetVerenigingen(string.Empty, string.Empty, verenigingsnummer).ToList<Vereniging>();
            }
            Vereniging found = verenigingen.SingleOrDefault(v => v.Verenigingsnummer == verenigingsnummer);
            if(found != null)
            {
                vereniging = found;
            }
            return vereniging;
        }

        public List<Vereniging> Verenigingen(string plaats)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();

            if (client != null)
            {
                verenigingen = client.GetVerenigingen(string.Empty, plaats, string.Empty).ToList<Vereniging>();
            }
            return verenigingen;
        }

        public List<Vereniging> Vereniging(Guid competitieId)
        {
            List<Vereniging> verenigingen = new List<Vereniging>();

            if (client != null)
            {
                verenigingen = client.GetVerenigingenByCompetitie(competitieId).ToList<Vereniging>();
            }
            return verenigingen;
        }

        public List<PartijResult> Uitslag(Guid wedstrijdId)
        {
            List<PartijResult> resultaat = new List<PartijResult>();

            if (client != null)
            {
                resultaat = client.GetWedstrijdPartijResults(string.Empty, wedstrijdId).ToList<PartijResult>();
            }
            return resultaat;
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler handler = this.PropertyChanged;
            if ((handler != null))
            {
                handler(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }

        public void Dispose()
        {
            if (client != null)
            {
                client.InnerChannel.Dispose();
                client = null;
            }
        }
    }
}
