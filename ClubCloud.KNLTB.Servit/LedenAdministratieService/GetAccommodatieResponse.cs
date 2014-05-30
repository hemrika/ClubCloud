using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetAccommodatieResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetAccommodatieResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private int AantalBinnenBanenField;

		private int AantalBuitenBanenField;

		private Adres AccommodatieAdresField;

		[OptionalField]
		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Blaashal? BlaashalField;

		private string BouwjaarClubhuisField;

		[OptionalField]
		private DateTime? DatumKeuringField;

		private string DistrictNaamField;

		private string EmailField;

		private string FaxnummerField;

		private string GekeurdDoorField;

		[OptionalField]
		private TypeHal? HalAanwezigField;

		private bool KleedruimteClubhuisAanwezigField;

		private bool MetOVBereikbaarField;

		[OptionalField]
		private int? MinderValideParkeerplaatsenField;

		private string MinibanenField;

		private string NaamField;

		private string OefenmurenField;

		private string OndergrondField;

		[OptionalField]
		private int? OppervlakteClubhuisField;

		[OptionalField]
		private SoortOverkapping? OverkappingField;

		private string PlaygroundsField;

		private Adres PostAdresField;

		private string RegioNaamField;

		[OptionalField]
		private TypeResultaatKeuring? ResultaatkeuringField;

		private bool RolStoeltoegankelijkField;

		private string SoortClubhuisField;

		private string SpeeltoestellenField;

		private string TelefoonnummerField;

		private string TenniskidshuisstijlField;

		[OptionalField]
		private int? TotaalAantalWasKleedruimteField;

		[OptionalField]
		private int? ValideParkeerplaatsenField;

		private bool WasruimteClubhuisAanwezigField;

		private string WebsiteField;

		[DataMember(IsRequired=true)]
		public int AantalBinnenBanen
		{
			get
			{
				return this.AantalBinnenBanenField;
			}
			set
			{
				if (!this.AantalBinnenBanenField.Equals(value))
				{
					this.AantalBinnenBanenField = value;
					this.RaisePropertyChanged("AantalBinnenBanen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalBuitenBanen
		{
			get
			{
				return this.AantalBuitenBanenField;
			}
			set
			{
				if (!this.AantalBuitenBanenField.Equals(value))
				{
					this.AantalBuitenBanenField = value;
					this.RaisePropertyChanged("AantalBuitenBanen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres AccommodatieAdres
		{
			get
			{
				return this.AccommodatieAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccommodatieAdresField, value))
				{
					this.AccommodatieAdresField = value;
					this.RaisePropertyChanged("AccommodatieAdres");
				}
			}
		}

		[DataMember]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Blaashal? Blaashal
		{
			get
			{
				return this.BlaashalField;
			}
			set
			{
				if (!this.BlaashalField.Equals(value))
				{
					this.BlaashalField = value;
					this.RaisePropertyChanged("Blaashal");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BouwjaarClubhuis
		{
			get
			{
				return this.BouwjaarClubhuisField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BouwjaarClubhuisField, value))
				{
					this.BouwjaarClubhuisField = value;
					this.RaisePropertyChanged("BouwjaarClubhuis");
				}
			}
		}

		[DataMember]
		public DateTime? DatumKeuring
		{
			get
			{
				return this.DatumKeuringField;
			}
			set
			{
				if (!this.DatumKeuringField.Equals(value))
				{
					this.DatumKeuringField = value;
					this.RaisePropertyChanged("DatumKeuring");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string DistrictNaam
		{
			get
			{
				return this.DistrictNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DistrictNaamField, value))
				{
					this.DistrictNaamField = value;
					this.RaisePropertyChanged("DistrictNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Email
		{
			get
			{
				return this.EmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailField, value))
				{
					this.EmailField = value;
					this.RaisePropertyChanged("Email");
				}
			}
		}

		[Browsable(false)]
		public ExtensionDataObject ExtensionData
		{
			get
			{
				return this.extensionDataField;
			}
			set
			{
				this.extensionDataField = value;
			}
		}

		[DataMember(IsRequired=true)]
		public string Faxnummer
		{
			get
			{
				return this.FaxnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FaxnummerField, value))
				{
					this.FaxnummerField = value;
					this.RaisePropertyChanged("Faxnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string GekeurdDoor
		{
			get
			{
				return this.GekeurdDoorField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GekeurdDoorField, value))
				{
					this.GekeurdDoorField = value;
					this.RaisePropertyChanged("GekeurdDoor");
				}
			}
		}

		[DataMember]
		public TypeHal? HalAanwezig
		{
			get
			{
				return this.HalAanwezigField;
			}
			set
			{
				if (!this.HalAanwezigField.Equals(value))
				{
					this.HalAanwezigField = value;
					this.RaisePropertyChanged("HalAanwezig");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool KleedruimteClubhuisAanwezig
		{
			get
			{
				return this.KleedruimteClubhuisAanwezigField;
			}
			set
			{
				if (!this.KleedruimteClubhuisAanwezigField.Equals(value))
				{
					this.KleedruimteClubhuisAanwezigField = value;
					this.RaisePropertyChanged("KleedruimteClubhuisAanwezig");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool MetOVBereikbaar
		{
			get
			{
				return this.MetOVBereikbaarField;
			}
			set
			{
				if (!this.MetOVBereikbaarField.Equals(value))
				{
					this.MetOVBereikbaarField = value;
					this.RaisePropertyChanged("MetOVBereikbaar");
				}
			}
		}

		[DataMember]
		public int? MinderValideParkeerplaatsen
		{
			get
			{
				return this.MinderValideParkeerplaatsenField;
			}
			set
			{
				if (!this.MinderValideParkeerplaatsenField.Equals(value))
				{
					this.MinderValideParkeerplaatsenField = value;
					this.RaisePropertyChanged("MinderValideParkeerplaatsen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Minibanen
		{
			get
			{
				return this.MinibanenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MinibanenField, value))
				{
					this.MinibanenField = value;
					this.RaisePropertyChanged("Minibanen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Naam
		{
			get
			{
				return this.NaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamField, value))
				{
					this.NaamField = value;
					this.RaisePropertyChanged("Naam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Oefenmuren
		{
			get
			{
				return this.OefenmurenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OefenmurenField, value))
				{
					this.OefenmurenField = value;
					this.RaisePropertyChanged("Oefenmuren");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Ondergrond
		{
			get
			{
				return this.OndergrondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OndergrondField, value))
				{
					this.OndergrondField = value;
					this.RaisePropertyChanged("Ondergrond");
				}
			}
		}

		[DataMember]
		public int? OppervlakteClubhuis
		{
			get
			{
				return this.OppervlakteClubhuisField;
			}
			set
			{
				if (!this.OppervlakteClubhuisField.Equals(value))
				{
					this.OppervlakteClubhuisField = value;
					this.RaisePropertyChanged("OppervlakteClubhuis");
				}
			}
		}

		[DataMember]
		public SoortOverkapping? Overkapping
		{
			get
			{
				return this.OverkappingField;
			}
			set
			{
				if (!this.OverkappingField.Equals(value))
				{
					this.OverkappingField = value;
					this.RaisePropertyChanged("Overkapping");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Playgrounds
		{
			get
			{
				return this.PlaygroundsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlaygroundsField, value))
				{
					this.PlaygroundsField = value;
					this.RaisePropertyChanged("Playgrounds");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres PostAdres
		{
			get
			{
				return this.PostAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostAdresField, value))
				{
					this.PostAdresField = value;
					this.RaisePropertyChanged("PostAdres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string RegioNaam
		{
			get
			{
				return this.RegioNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RegioNaamField, value))
				{
					this.RegioNaamField = value;
					this.RaisePropertyChanged("RegioNaam");
				}
			}
		}

		[DataMember]
		public TypeResultaatKeuring? Resultaatkeuring
		{
			get
			{
				return this.ResultaatkeuringField;
			}
			set
			{
				if (!this.ResultaatkeuringField.Equals(value))
				{
					this.ResultaatkeuringField = value;
					this.RaisePropertyChanged("Resultaatkeuring");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool RolStoeltoegankelijk
		{
			get
			{
				return this.RolStoeltoegankelijkField;
			}
			set
			{
				if (!this.RolStoeltoegankelijkField.Equals(value))
				{
					this.RolStoeltoegankelijkField = value;
					this.RaisePropertyChanged("RolStoeltoegankelijk");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string SoortClubhuis
		{
			get
			{
				return this.SoortClubhuisField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SoortClubhuisField, value))
				{
					this.SoortClubhuisField = value;
					this.RaisePropertyChanged("SoortClubhuis");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Speeltoestellen
		{
			get
			{
				return this.SpeeltoestellenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpeeltoestellenField, value))
				{
					this.SpeeltoestellenField = value;
					this.RaisePropertyChanged("Speeltoestellen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Telefoonnummer
		{
			get
			{
				return this.TelefoonnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonnummerField, value))
				{
					this.TelefoonnummerField = value;
					this.RaisePropertyChanged("Telefoonnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Tenniskidshuisstijl
		{
			get
			{
				return this.TenniskidshuisstijlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TenniskidshuisstijlField, value))
				{
					this.TenniskidshuisstijlField = value;
					this.RaisePropertyChanged("Tenniskidshuisstijl");
				}
			}
		}

		[DataMember]
		public int? TotaalAantalWasKleedruimte
		{
			get
			{
				return this.TotaalAantalWasKleedruimteField;
			}
			set
			{
				if (!this.TotaalAantalWasKleedruimteField.Equals(value))
				{
					this.TotaalAantalWasKleedruimteField = value;
					this.RaisePropertyChanged("TotaalAantalWasKleedruimte");
				}
			}
		}

		[DataMember]
		public int? ValideParkeerplaatsen
		{
			get
			{
				return this.ValideParkeerplaatsenField;
			}
			set
			{
				if (!this.ValideParkeerplaatsenField.Equals(value))
				{
					this.ValideParkeerplaatsenField = value;
					this.RaisePropertyChanged("ValideParkeerplaatsen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool WasruimteClubhuisAanwezig
		{
			get
			{
				return this.WasruimteClubhuisAanwezigField;
			}
			set
			{
				if (!this.WasruimteClubhuisAanwezigField.Equals(value))
				{
					this.WasruimteClubhuisAanwezigField = value;
					this.RaisePropertyChanged("WasruimteClubhuisAanwezig");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Website
		{
			get
			{
				return this.WebsiteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WebsiteField, value))
				{
					this.WebsiteField = value;
					this.RaisePropertyChanged("Website");
				}
			}
		}

		public GetAccommodatieResponse()
		{
		}

		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChangedEventHandler = this.PropertyChanged;
			if (propertyChangedEventHandler != null)
			{
				propertyChangedEventHandler(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public event PropertyChangedEventHandler PropertyChanged;
	}
}