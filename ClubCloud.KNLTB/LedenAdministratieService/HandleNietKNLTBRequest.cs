using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="HandleNietKNLTBRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleNietKNLTBRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AchternaamField;

		[OptionalField]
		private string EmailField;

		private DateTime GeboortedatumField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		private string PlaatsField;

		private string PostcodeField;

		private string StraatField;

		[OptionalField]
		private string TelefoonnummerField;

		private string TussenvoegselField;

		private string VoornaamField;

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
		public DateTime Geboortedatum
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

		[DataMember]
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
		public string Voornaam
		{
			get
			{
				return this.VoornaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VoornaamField, value))
				{
					this.VoornaamField = value;
					this.RaisePropertyChanged("Voornaam");
				}
			}
		}

		public HandleNietKNLTBRequest()
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