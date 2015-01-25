using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekSpelersProfielenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekSpelersProfielenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AchternaamField;

		private string BondsnummerField;

		private int CountNumberField;

		private bool DamesMeisjesField;

		[OptionalField]
		private int? GeboortejaarTMField;

		[OptionalField]
		private int? GeboortejaarVanafField;

		private bool HerenJongensField;

		[OptionalField]
		private Guid? OrganisatieRegioIdField;

		private int PageNumberField;

		private TypeRating RatingField;

		[OptionalField]
		private int? SpeelSterkeTMField;

		[OptionalField]
		private int? SpeelSterkteVanafField;

		private Spelsoort SpelSoortField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.TypeOrganisatieVereniging TypeOrganisatieVerenigingField;

		[DataMember]
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
		public int CountNumber
		{
			get
			{
				return this.CountNumberField;
			}
			set
			{
				if (!this.CountNumberField.Equals(value))
				{
					this.CountNumberField = value;
					this.RaisePropertyChanged("CountNumber");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool DamesMeisjes
		{
			get
			{
				return this.DamesMeisjesField;
			}
			set
			{
				if (!this.DamesMeisjesField.Equals(value))
				{
					this.DamesMeisjesField = value;
					this.RaisePropertyChanged("DamesMeisjes");
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

		[DataMember]
		public int? GeboortejaarTM
		{
			get
			{
				return this.GeboortejaarTMField;
			}
			set
			{
				if (!this.GeboortejaarTMField.Equals(value))
				{
					this.GeboortejaarTMField = value;
					this.RaisePropertyChanged("GeboortejaarTM");
				}
			}
		}

		[DataMember]
		public int? GeboortejaarVanaf
		{
			get
			{
				return this.GeboortejaarVanafField;
			}
			set
			{
				if (!this.GeboortejaarVanafField.Equals(value))
				{
					this.GeboortejaarVanafField = value;
					this.RaisePropertyChanged("GeboortejaarVanaf");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool HerenJongens
		{
			get
			{
				return this.HerenJongensField;
			}
			set
			{
				if (!this.HerenJongensField.Equals(value))
				{
					this.HerenJongensField = value;
					this.RaisePropertyChanged("HerenJongens");
				}
			}
		}

		[DataMember]
		public Guid? OrganisatieRegioId
		{
			get
			{
				return this.OrganisatieRegioIdField;
			}
			set
			{
				if (!this.OrganisatieRegioIdField.Equals(value))
				{
					this.OrganisatieRegioIdField = value;
					this.RaisePropertyChanged("OrganisatieRegioId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int PageNumber
		{
			get
			{
				return this.PageNumberField;
			}
			set
			{
				if (!this.PageNumberField.Equals(value))
				{
					this.PageNumberField = value;
					this.RaisePropertyChanged("PageNumber");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public TypeRating Rating
		{
			get
			{
				return this.RatingField;
			}
			set
			{
				if (!this.RatingField.Equals(value))
				{
					this.RatingField = value;
					this.RaisePropertyChanged("Rating");
				}
			}
		}

		[DataMember]
		public int? SpeelSterkeTM
		{
			get
			{
				return this.SpeelSterkeTMField;
			}
			set
			{
				if (!this.SpeelSterkeTMField.Equals(value))
				{
					this.SpeelSterkeTMField = value;
					this.RaisePropertyChanged("SpeelSterkeTM");
				}
			}
		}

		[DataMember]
		public int? SpeelSterkteVanaf
		{
			get
			{
				return this.SpeelSterkteVanafField;
			}
			set
			{
				if (!this.SpeelSterkteVanafField.Equals(value))
				{
					this.SpeelSterkteVanafField = value;
					this.RaisePropertyChanged("SpeelSterkteVanaf");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Spelsoort SpelSoort
		{
			get
			{
				return this.SpelSoortField;
			}
			set
			{
				if (!this.SpelSoortField.Equals(value))
				{
					this.SpelSoortField = value;
					this.RaisePropertyChanged("SpelSoort");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.TypeOrganisatieVereniging TypeOrganisatieVereniging
		{
			get
			{
				return this.TypeOrganisatieVerenigingField;
			}
			set
			{
				if (!this.TypeOrganisatieVerenigingField.Equals(value))
				{
					this.TypeOrganisatieVerenigingField = value;
					this.RaisePropertyChanged("TypeOrganisatieVereniging");
				}
			}
		}

		public ZoekSpelersProfielenRequest()
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