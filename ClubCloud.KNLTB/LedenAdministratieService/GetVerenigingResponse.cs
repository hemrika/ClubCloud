using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetVerenigingResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetVerenigingResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BanknummerPlaatsField;

		private string BezoekadresField;

		private string BezoekadresGemeenteField;

		private string BezoekadresPlaatsField;

		private string BezoekadresPostcodeField;

		[OptionalField]
		private DateTime? DatumOpgerichtField;

		private string DistrictField;

		private string EmailadresField;

		private string IbanCodeField;

		private string KvKnummerField;

		private string KvKplaatsField;

		private string NaamField;

		private string PostadresField;

		private string PostadresGemeenteField;

		private string PostadresPlaatsField;

		private string PostadresPostcodeField;

		private string RegioField;

		private string TelefoonnummerAvondField;

		private string TelefoonnummerOverdagField;

		private string VerenigingsnummerField;

		private string WebsiteField;

		[DataMember(IsRequired=true)]
		public string BanknummerPlaats
		{
			get
			{
				return this.BanknummerPlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BanknummerPlaatsField, value))
				{
					this.BanknummerPlaatsField = value;
					this.RaisePropertyChanged("BanknummerPlaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Bezoekadres
		{
			get
			{
				return this.BezoekadresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BezoekadresField, value))
				{
					this.BezoekadresField = value;
					this.RaisePropertyChanged("Bezoekadres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BezoekadresGemeente
		{
			get
			{
				return this.BezoekadresGemeenteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BezoekadresGemeenteField, value))
				{
					this.BezoekadresGemeenteField = value;
					this.RaisePropertyChanged("BezoekadresGemeente");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BezoekadresPlaats
		{
			get
			{
				return this.BezoekadresPlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BezoekadresPlaatsField, value))
				{
					this.BezoekadresPlaatsField = value;
					this.RaisePropertyChanged("BezoekadresPlaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BezoekadresPostcode
		{
			get
			{
				return this.BezoekadresPostcodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BezoekadresPostcodeField, value))
				{
					this.BezoekadresPostcodeField = value;
					this.RaisePropertyChanged("BezoekadresPostcode");
				}
			}
		}

		[DataMember]
		public DateTime? DatumOpgericht
		{
			get
			{
				return this.DatumOpgerichtField;
			}
			set
			{
				if (!this.DatumOpgerichtField.Equals(value))
				{
					this.DatumOpgerichtField = value;
					this.RaisePropertyChanged("DatumOpgericht");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string District
		{
			get
			{
				return this.DistrictField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DistrictField, value))
				{
					this.DistrictField = value;
					this.RaisePropertyChanged("District");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Emailadres
		{
			get
			{
				return this.EmailadresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailadresField, value))
				{
					this.EmailadresField = value;
					this.RaisePropertyChanged("Emailadres");
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
		public string IbanCode
		{
			get
			{
				return this.IbanCodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IbanCodeField, value))
				{
					this.IbanCodeField = value;
					this.RaisePropertyChanged("IbanCode");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string KvKnummer
		{
			get
			{
				return this.KvKnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KvKnummerField, value))
				{
					this.KvKnummerField = value;
					this.RaisePropertyChanged("KvKnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string KvKplaats
		{
			get
			{
				return this.KvKplaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KvKplaatsField, value))
				{
					this.KvKplaatsField = value;
					this.RaisePropertyChanged("KvKplaats");
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
		public string Postadres
		{
			get
			{
				return this.PostadresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostadresField, value))
				{
					this.PostadresField = value;
					this.RaisePropertyChanged("Postadres");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PostadresGemeente
		{
			get
			{
				return this.PostadresGemeenteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostadresGemeenteField, value))
				{
					this.PostadresGemeenteField = value;
					this.RaisePropertyChanged("PostadresGemeente");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PostadresPlaats
		{
			get
			{
				return this.PostadresPlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostadresPlaatsField, value))
				{
					this.PostadresPlaatsField = value;
					this.RaisePropertyChanged("PostadresPlaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PostadresPostcode
		{
			get
			{
				return this.PostadresPostcodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostadresPostcodeField, value))
				{
					this.PostadresPostcodeField = value;
					this.RaisePropertyChanged("PostadresPostcode");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Regio
		{
			get
			{
				return this.RegioField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RegioField, value))
				{
					this.RegioField = value;
					this.RaisePropertyChanged("Regio");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TelefoonnummerAvond
		{
			get
			{
				return this.TelefoonnummerAvondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonnummerAvondField, value))
				{
					this.TelefoonnummerAvondField = value;
					this.RaisePropertyChanged("TelefoonnummerAvond");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string TelefoonnummerOverdag
		{
			get
			{
				return this.TelefoonnummerOverdagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonnummerOverdagField, value))
				{
					this.TelefoonnummerOverdagField = value;
					this.RaisePropertyChanged("TelefoonnummerOverdag");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Verenigingsnummer
		{
			get
			{
				return this.VerenigingsnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsnummerField, value))
				{
					this.VerenigingsnummerField = value;
					this.RaisePropertyChanged("Verenigingsnummer");
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

		public GetVerenigingResponse()
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