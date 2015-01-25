using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="Persoonsgegevens", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Persoonsgegevens : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AchternaamField;

		private string DistrictNaamField;

		private string EmailField;

		private DateTime? GeboortedatumField;

		private string GeboorteplaatsField;

		private string GemeenteField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		private string HuisnummerField;

		private Guid IdField;

		private bool IsLidField;

		private string MobielField;

		[OptionalField]
		private Guid? NationaliteitIdField;

		private string OrganisatieNummerField;

		private string PlaatsField;

		private string PostcodeField;

		[OptionalField]
		private decimal? RatingDubbelField;

		[OptionalField]
		private decimal? RatingEnkelField;

		private string RoepnaamField;

		[OptionalField]
		private int? SpeelsterkteDubbelField;

		[OptionalField]
		private int? SpeelsterkteEnkelField;

		private string StraatField;

		private string TelefoonAvondField;

		private string TelefoonOverdagField;

		private string ToevoegingField;

		private string TussenvoegselField;

		private string VolledigeNaamField;

		private string VoorlettersField;

		private string VoornamenField;

		[DataMember(IsRequired=true)]
		public string Achternaam
		{
			get
			{
				return this.AchternaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AchternaamField, value))
				{
					this.AchternaamField = value;
					this.RaisePropertyChanged("Achternaam");
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
		public DateTime? Geboortedatum
		{
			get
			{
				return this.GeboortedatumField;
			}
			set
			{
				if (!this.GeboortedatumField.Equals(value))
				{
					this.GeboortedatumField = value;
					this.RaisePropertyChanged("Geboortedatum");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Geboorteplaats
		{
			get
			{
				return this.GeboorteplaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GeboorteplaatsField, value))
				{
					this.GeboorteplaatsField = value;
					this.RaisePropertyChanged("Geboorteplaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Gemeente
		{
			get
			{
				return this.GemeenteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GemeenteField, value))
				{
					this.GemeenteField = value;
					this.RaisePropertyChanged("Gemeente");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht Geslacht
		{
			get
			{
				return this.GeslachtField;
			}
			set
			{
				if (!this.GeslachtField.Equals(value))
				{
					this.GeslachtField = value;
					this.RaisePropertyChanged("Geslacht");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Huisnummer
		{
			get
			{
				return this.HuisnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HuisnummerField, value))
				{
					this.HuisnummerField = value;
					this.RaisePropertyChanged("Huisnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool IsLid
		{
			get
			{
				return this.IsLidField;
			}
			set
			{
				if (!this.IsLidField.Equals(value))
				{
					this.IsLidField = value;
					this.RaisePropertyChanged("IsLid");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Mobiel
		{
			get
			{
				return this.MobielField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MobielField, value))
				{
					this.MobielField = value;
					this.RaisePropertyChanged("Mobiel");
				}
			}
		}

		[DataMember]
		public Guid? NationaliteitId
		{
			get
			{
				return this.NationaliteitIdField;
			}
			set
			{
				if (!this.NationaliteitIdField.Equals(value))
				{
					this.NationaliteitIdField = value;
					this.RaisePropertyChanged("NationaliteitId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string OrganisatieNummer
		{
			get
			{
				return this.OrganisatieNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatieNummerField, value))
				{
					this.OrganisatieNummerField = value;
					this.RaisePropertyChanged("OrganisatieNummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Plaats
		{
			get
			{
				return this.PlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlaatsField, value))
				{
					this.PlaatsField = value;
					this.RaisePropertyChanged("Plaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Postcode
		{
			get
			{
				return this.PostcodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostcodeField, value))
				{
					this.PostcodeField = value;
					this.RaisePropertyChanged("Postcode");
				}
			}
		}

		[DataMember]
		public decimal? RatingDubbel
		{
			get
			{
				return this.RatingDubbelField;
			}
			set
			{
				if (!this.RatingDubbelField.Equals(value))
				{
					this.RatingDubbelField = value;
					this.RaisePropertyChanged("RatingDubbel");
				}
			}
		}

		[DataMember]
		public decimal? RatingEnkel
		{
			get
			{
				return this.RatingEnkelField;
			}
			set
			{
				if (!this.RatingEnkelField.Equals(value))
				{
					this.RatingEnkelField = value;
					this.RaisePropertyChanged("RatingEnkel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Roepnaam
		{
			get
			{
				return this.RoepnaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RoepnaamField, value))
				{
					this.RoepnaamField = value;
					this.RaisePropertyChanged("Roepnaam");
				}
			}
		}

		[DataMember]
		public int? SpeelsterkteDubbel
		{
			get
			{
				return this.SpeelsterkteDubbelField;
			}
			set
			{
				if (!this.SpeelsterkteDubbelField.Equals(value))
				{
					this.SpeelsterkteDubbelField = value;
					this.RaisePropertyChanged("SpeelsterkteDubbel");
				}
			}
		}

		[DataMember]
		public int? SpeelsterkteEnkel
		{
			get
			{
				return this.SpeelsterkteEnkelField;
			}
			set
			{
				if (!this.SpeelsterkteEnkelField.Equals(value))
				{
					this.SpeelsterkteEnkelField = value;
					this.RaisePropertyChanged("SpeelsterkteEnkel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Straat
		{
			get
			{
				return this.StraatField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StraatField, value))
				{
					this.StraatField = value;
					this.RaisePropertyChanged("Straat");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TelefoonAvond
		{
			get
			{
				return this.TelefoonAvondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonAvondField, value))
				{
					this.TelefoonAvondField = value;
					this.RaisePropertyChanged("TelefoonAvond");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TelefoonOverdag
		{
			get
			{
				return this.TelefoonOverdagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonOverdagField, value))
				{
					this.TelefoonOverdagField = value;
					this.RaisePropertyChanged("TelefoonOverdag");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Toevoeging
		{
			get
			{
				return this.ToevoegingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToevoegingField, value))
				{
					this.ToevoegingField = value;
					this.RaisePropertyChanged("Toevoeging");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Tussenvoegsel
		{
			get
			{
				return this.TussenvoegselField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TussenvoegselField, value))
				{
					this.TussenvoegselField = value;
					this.RaisePropertyChanged("Tussenvoegsel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string VolledigeNaam
		{
			get
			{
				return this.VolledigeNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VolledigeNaamField, value))
				{
					this.VolledigeNaamField = value;
					this.RaisePropertyChanged("VolledigeNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Voorletters
		{
			get
			{
				return this.VoorlettersField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VoorlettersField, value))
				{
					this.VoorlettersField = value;
					this.RaisePropertyChanged("Voorletters");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Voornamen
		{
			get
			{
				return this.VoornamenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VoornamenField, value))
				{
					this.VoornamenField = value;
					this.RaisePropertyChanged("Voornamen");
				}
			}
		}

		public Persoonsgegevens()
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