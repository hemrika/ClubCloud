using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ToernooiForVereniging", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ToernooiForVereniging : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Adres AccommodatieAdresField;

		private string AccommodatieEmailField;

		[OptionalField]
		private Guid? AccommodatieIdField;

		private string AccommodatieNaamField;

		private string AccommodatieTelefoonField;

		[OptionalField]
		private DateTime? BeginDatumField;

		private Adres BondsgedelegeerdeAdresField;

		private string BondsgedelegeerdeEmailField;

		private string BondsgedelegeerdeNaamField;

		private string BondsgedelegeerdeTelefoonField;

		[OptionalField]
		private Guid? ContactPersoonIdField;

		private string ContactPersoonNaamField;

		private string DistrictNaamField;

		[OptionalField]
		private DateTime? EindDatumField;

		private Guid IdField;

		private string NaamField;

		private Adres OrganisatieAdresField;

		private string OrganisatieEmailField;

		private string OrganisatieNummerField;

		private string OrganisatieTelefoonField;

		[OptionalField]
		private Guid? ToernooiorganisatieIdField;

		private string ToernooiorganisatieNaamField;

		private string ToernooisoortField;

		private string WebsiteOrganisatieField;

		private Adres WedstrijdLeiderAdresField;

		private string WedstrijdLeiderEmailField;

		private string WedstrijdLeiderNaamField;

		private string WedstrijdLeiderTelefoonField;

		private string WeeknummerBeginField;

		private string WeeknummerTMField;

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

		[DataMember(IsRequired=true)]
		public string AccommodatieEmail
		{
			get
			{
				return this.AccommodatieEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccommodatieEmailField, value))
				{
					this.AccommodatieEmailField = value;
					this.RaisePropertyChanged("AccommodatieEmail");
				}
			}
		}

		[DataMember]
		public Guid? AccommodatieId
		{
			get
			{
				return this.AccommodatieIdField;
			}
			set
			{
				if (!this.AccommodatieIdField.Equals(value))
				{
					this.AccommodatieIdField = value;
					this.RaisePropertyChanged("AccommodatieId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string AccommodatieNaam
		{
			get
			{
				return this.AccommodatieNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccommodatieNaamField, value))
				{
					this.AccommodatieNaamField = value;
					this.RaisePropertyChanged("AccommodatieNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string AccommodatieTelefoon
		{
			get
			{
				return this.AccommodatieTelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AccommodatieTelefoonField, value))
				{
					this.AccommodatieTelefoonField = value;
					this.RaisePropertyChanged("AccommodatieTelefoon");
				}
			}
		}

		[DataMember]
		public DateTime? BeginDatum
		{
			get
			{
				return this.BeginDatumField;
			}
			set
			{
				if (!this.BeginDatumField.Equals(value))
				{
					this.BeginDatumField = value;
					this.RaisePropertyChanged("BeginDatum");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres BondsgedelegeerdeAdres
		{
			get
			{
				return this.BondsgedelegeerdeAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsgedelegeerdeAdresField, value))
				{
					this.BondsgedelegeerdeAdresField = value;
					this.RaisePropertyChanged("BondsgedelegeerdeAdres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsgedelegeerdeEmail
		{
			get
			{
				return this.BondsgedelegeerdeEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsgedelegeerdeEmailField, value))
				{
					this.BondsgedelegeerdeEmailField = value;
					this.RaisePropertyChanged("BondsgedelegeerdeEmail");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsgedelegeerdeNaam
		{
			get
			{
				return this.BondsgedelegeerdeNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsgedelegeerdeNaamField, value))
				{
					this.BondsgedelegeerdeNaamField = value;
					this.RaisePropertyChanged("BondsgedelegeerdeNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsgedelegeerdeTelefoon
		{
			get
			{
				return this.BondsgedelegeerdeTelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsgedelegeerdeTelefoonField, value))
				{
					this.BondsgedelegeerdeTelefoonField = value;
					this.RaisePropertyChanged("BondsgedelegeerdeTelefoon");
				}
			}
		}

		[DataMember]
		public Guid? ContactPersoonId
		{
			get
			{
				return this.ContactPersoonIdField;
			}
			set
			{
				if (!this.ContactPersoonIdField.Equals(value))
				{
					this.ContactPersoonIdField = value;
					this.RaisePropertyChanged("ContactPersoonId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ContactPersoonNaam
		{
			get
			{
				return this.ContactPersoonNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ContactPersoonNaamField, value))
				{
					this.ContactPersoonNaamField = value;
					this.RaisePropertyChanged("ContactPersoonNaam");
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

		[DataMember]
		public DateTime? EindDatum
		{
			get
			{
				return this.EindDatumField;
			}
			set
			{
				if (!this.EindDatumField.Equals(value))
				{
					this.EindDatumField = value;
					this.RaisePropertyChanged("EindDatum");
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
		public Adres OrganisatieAdres
		{
			get
			{
				return this.OrganisatieAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatieAdresField, value))
				{
					this.OrganisatieAdresField = value;
					this.RaisePropertyChanged("OrganisatieAdres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string OrganisatieEmail
		{
			get
			{
				return this.OrganisatieEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatieEmailField, value))
				{
					this.OrganisatieEmailField = value;
					this.RaisePropertyChanged("OrganisatieEmail");
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
		public string OrganisatieTelefoon
		{
			get
			{
				return this.OrganisatieTelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatieTelefoonField, value))
				{
					this.OrganisatieTelefoonField = value;
					this.RaisePropertyChanged("OrganisatieTelefoon");
				}
			}
		}

		[DataMember]
		public Guid? ToernooiorganisatieId
		{
			get
			{
				return this.ToernooiorganisatieIdField;
			}
			set
			{
				if (!this.ToernooiorganisatieIdField.Equals(value))
				{
					this.ToernooiorganisatieIdField = value;
					this.RaisePropertyChanged("ToernooiorganisatieId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ToernooiorganisatieNaam
		{
			get
			{
				return this.ToernooiorganisatieNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToernooiorganisatieNaamField, value))
				{
					this.ToernooiorganisatieNaamField = value;
					this.RaisePropertyChanged("ToernooiorganisatieNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Toernooisoort
		{
			get
			{
				return this.ToernooisoortField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToernooisoortField, value))
				{
					this.ToernooisoortField = value;
					this.RaisePropertyChanged("Toernooisoort");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WebsiteOrganisatie
		{
			get
			{
				return this.WebsiteOrganisatieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WebsiteOrganisatieField, value))
				{
					this.WebsiteOrganisatieField = value;
					this.RaisePropertyChanged("WebsiteOrganisatie");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Adres WedstrijdLeiderAdres
		{
			get
			{
				return this.WedstrijdLeiderAdresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdLeiderAdresField, value))
				{
					this.WedstrijdLeiderAdresField = value;
					this.RaisePropertyChanged("WedstrijdLeiderAdres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WedstrijdLeiderEmail
		{
			get
			{
				return this.WedstrijdLeiderEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdLeiderEmailField, value))
				{
					this.WedstrijdLeiderEmailField = value;
					this.RaisePropertyChanged("WedstrijdLeiderEmail");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WedstrijdLeiderNaam
		{
			get
			{
				return this.WedstrijdLeiderNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdLeiderNaamField, value))
				{
					this.WedstrijdLeiderNaamField = value;
					this.RaisePropertyChanged("WedstrijdLeiderNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WedstrijdLeiderTelefoon
		{
			get
			{
				return this.WedstrijdLeiderTelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdLeiderTelefoonField, value))
				{
					this.WedstrijdLeiderTelefoonField = value;
					this.RaisePropertyChanged("WedstrijdLeiderTelefoon");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WeeknummerBegin
		{
			get
			{
				return this.WeeknummerBeginField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WeeknummerBeginField, value))
				{
					this.WeeknummerBeginField = value;
					this.RaisePropertyChanged("WeeknummerBegin");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string WeeknummerTM
		{
			get
			{
				return this.WeeknummerTMField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WeeknummerTMField, value))
				{
					this.WeeknummerTMField = value;
					this.RaisePropertyChanged("WeeknummerTM");
				}
			}
		}

		public ToernooiForVereniging()
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