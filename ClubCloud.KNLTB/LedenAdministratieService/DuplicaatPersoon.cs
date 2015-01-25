using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="DuplicaatPersoon", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class DuplicaatPersoon : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AchternaamField;

		[OptionalField]
		private string BondsnummerField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.DuplicatenCombinatieType DuplicatenCombinatieTypeField;

		private string EmailField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.EntiteitType EntiteitTypeField;

		private DateTime? GeboortedatumField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		private string HuisnummerField;

		private Guid? IdField;

		[OptionalField]
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

		[OptionalField]
		private string StraatField;

		private string TelefoonField;

		[OptionalField]
		private string ToevoegingField;

		[OptionalField]
		private string TussenvoegselField;

		private string VolledigeNaamField;

		private string VoorlettersField;

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

		[DataMember]
		public string Bondsnummer
		{
			get
			{
				return this.BondsnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerField, value))
				{
					this.BondsnummerField = value;
					this.RaisePropertyChanged("Bondsnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.DuplicatenCombinatieType DuplicatenCombinatieType
		{
			get
			{
				return this.DuplicatenCombinatieTypeField;
			}
			set
			{
				if (!this.DuplicatenCombinatieTypeField.Equals(value))
				{
					this.DuplicatenCombinatieTypeField = value;
					this.RaisePropertyChanged("DuplicatenCombinatieType");
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

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.EntiteitType EntiteitType
		{
			get
			{
				return this.EntiteitTypeField;
			}
			set
			{
				if (!this.EntiteitTypeField.Equals(value))
				{
					this.EntiteitTypeField = value;
					this.RaisePropertyChanged("EntiteitType");
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
		public Guid? Id
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

		[DataMember]
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

		[DataMember]
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
		public string Telefoon
		{
			get
			{
				return this.TelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonField, value))
				{
					this.TelefoonField = value;
					this.RaisePropertyChanged("Telefoon");
				}
			}
		}

		[DataMember]
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

		[DataMember]
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

		public DuplicaatPersoon()
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