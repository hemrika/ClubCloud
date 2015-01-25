using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="Wedstrijdgegevens", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Wedstrijdgegevens : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private DateTime? AanvangField;

		[OptionalField]
		private string AanvoerderField;

		private string AanvullendeInformatieField;

		[OptionalField]
		private DateTime? AanwezigField;

		[OptionalField]
		private Guid? AccommodatieIdField;

		[OptionalField]
		private string AccommodatieNaamField;

		private string AfdelingField;

		private string BaansoortField;

		private string CompetitieField;

		private Guid IdField;

		[OptionalField]
		private DateTime? SpeeldatumField;

		private string TelefoonField;

		[OptionalField]
		private string ThuisploegField;

		[OptionalField]
		private string UitploegField;

		private string WedstrijdField;

		[DataMember]
		public DateTime? Aanvang
		{
			get
			{
				return this.AanvangField;
			}
			set
			{
				if (!this.AanvangField.Equals(value))
				{
					this.AanvangField = value;
					this.RaisePropertyChanged("Aanvang");
				}
			}
		}

		[DataMember]
		public string Aanvoerder
		{
			get
			{
				return this.AanvoerderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AanvoerderField, value))
				{
					this.AanvoerderField = value;
					this.RaisePropertyChanged("Aanvoerder");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string AanvullendeInformatie
		{
			get
			{
				return this.AanvullendeInformatieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AanvullendeInformatieField, value))
				{
					this.AanvullendeInformatieField = value;
					this.RaisePropertyChanged("AanvullendeInformatie");
				}
			}
		}

		[DataMember]
		public DateTime? Aanwezig
		{
			get
			{
				return this.AanwezigField;
			}
			set
			{
				if (!this.AanwezigField.Equals(value))
				{
					this.AanwezigField = value;
					this.RaisePropertyChanged("Aanwezig");
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

		[DataMember]
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
		public string Afdeling
		{
			get
			{
				return this.AfdelingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AfdelingField, value))
				{
					this.AfdelingField = value;
					this.RaisePropertyChanged("Afdeling");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Baansoort
		{
			get
			{
				return this.BaansoortField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BaansoortField, value))
				{
					this.BaansoortField = value;
					this.RaisePropertyChanged("Baansoort");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Competitie
		{
			get
			{
				return this.CompetitieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CompetitieField, value))
				{
					this.CompetitieField = value;
					this.RaisePropertyChanged("Competitie");
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

		[DataMember]
		public DateTime? Speeldatum
		{
			get
			{
				return this.SpeeldatumField;
			}
			set
			{
				if (!this.SpeeldatumField.Equals(value))
				{
					this.SpeeldatumField = value;
					this.RaisePropertyChanged("Speeldatum");
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
		public string Thuisploeg
		{
			get
			{
				return this.ThuisploegField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThuisploegField, value))
				{
					this.ThuisploegField = value;
					this.RaisePropertyChanged("Thuisploeg");
				}
			}
		}

		[DataMember]
		public string Uitploeg
		{
			get
			{
				return this.UitploegField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UitploegField, value))
				{
					this.UitploegField = value;
					this.RaisePropertyChanged("Uitploeg");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Wedstrijd
		{
			get
			{
				return this.WedstrijdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdField, value))
				{
					this.WedstrijdField = value;
					this.RaisePropertyChanged("Wedstrijd");
				}
			}
		}

		public Wedstrijdgegevens()
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