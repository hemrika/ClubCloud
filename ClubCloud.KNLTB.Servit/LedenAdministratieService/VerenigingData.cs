using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="VerenigingData", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services.Relatiebeheer")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class VerenigingData : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int AantalLedenField;

		[OptionalField]
		private Baansoort[] BaansoortenField;

		[OptionalField]
		private string DistrictField;

		[OptionalField]
		private Guid? DistrictIdField;

		[OptionalField]
		private string EigenaarAccommodatieField;

		[OptionalField]
		private Guid? EigenaarAccommodatieIdField;

		[OptionalField]
		private string EigenaarClubhuisField;

		[OptionalField]
		private Guid? EigenaarClubhuisIdField;

		[OptionalField]
		private string EigenaarGrondField;

		[OptionalField]
		private Guid? EigenaarGrondIdField;

		[OptionalField]
		private string EmailadresField;

		[OptionalField]
		private string RegioField;

		[OptionalField]
		private Guid? RegioIdField;

		[OptionalField]
		private Guid VerenigingIdField;

		[OptionalField]
		private string VerenigingNaamField;

		[OptionalField]
		private string VerenigingsnummerField;

		[DataMember]
		public int AantalLeden
		{
			get
			{
				return this.AantalLedenField;
			}
			set
			{
				if (!this.AantalLedenField.Equals(value))
				{
					this.AantalLedenField = value;
					this.RaisePropertyChanged("AantalLeden");
				}
			}
		}

		[DataMember]
		public Baansoort[] Baansoorten
		{
			get
			{
				return this.BaansoortenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BaansoortenField, value))
				{
					this.BaansoortenField = value;
					this.RaisePropertyChanged("Baansoorten");
				}
			}
		}

		[DataMember]
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

		[DataMember]
		public Guid? DistrictId
		{
			get
			{
				return this.DistrictIdField;
			}
			set
			{
				if (!this.DistrictIdField.Equals(value))
				{
					this.DistrictIdField = value;
					this.RaisePropertyChanged("DistrictId");
				}
			}
		}

		[DataMember]
		public string EigenaarAccommodatie
		{
			get
			{
				return this.EigenaarAccommodatieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EigenaarAccommodatieField, value))
				{
					this.EigenaarAccommodatieField = value;
					this.RaisePropertyChanged("EigenaarAccommodatie");
				}
			}
		}

		[DataMember]
		public Guid? EigenaarAccommodatieId
		{
			get
			{
				return this.EigenaarAccommodatieIdField;
			}
			set
			{
				if (!this.EigenaarAccommodatieIdField.Equals(value))
				{
					this.EigenaarAccommodatieIdField = value;
					this.RaisePropertyChanged("EigenaarAccommodatieId");
				}
			}
		}

		[DataMember]
		public string EigenaarClubhuis
		{
			get
			{
				return this.EigenaarClubhuisField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EigenaarClubhuisField, value))
				{
					this.EigenaarClubhuisField = value;
					this.RaisePropertyChanged("EigenaarClubhuis");
				}
			}
		}

		[DataMember]
		public Guid? EigenaarClubhuisId
		{
			get
			{
				return this.EigenaarClubhuisIdField;
			}
			set
			{
				if (!this.EigenaarClubhuisIdField.Equals(value))
				{
					this.EigenaarClubhuisIdField = value;
					this.RaisePropertyChanged("EigenaarClubhuisId");
				}
			}
		}

		[DataMember]
		public string EigenaarGrond
		{
			get
			{
				return this.EigenaarGrondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EigenaarGrondField, value))
				{
					this.EigenaarGrondField = value;
					this.RaisePropertyChanged("EigenaarGrond");
				}
			}
		}

		[DataMember]
		public Guid? EigenaarGrondId
		{
			get
			{
				return this.EigenaarGrondIdField;
			}
			set
			{
				if (!this.EigenaarGrondIdField.Equals(value))
				{
					this.EigenaarGrondIdField = value;
					this.RaisePropertyChanged("EigenaarGrondId");
				}
			}
		}

		[DataMember]
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

		[DataMember]
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

		[DataMember]
		public Guid? RegioId
		{
			get
			{
				return this.RegioIdField;
			}
			set
			{
				if (!this.RegioIdField.Equals(value))
				{
					this.RegioIdField = value;
					this.RaisePropertyChanged("RegioId");
				}
			}
		}

		[DataMember]
		public Guid VerenigingId
		{
			get
			{
				return this.VerenigingIdField;
			}
			set
			{
				if (!this.VerenigingIdField.Equals(value))
				{
					this.VerenigingIdField = value;
					this.RaisePropertyChanged("VerenigingId");
				}
			}
		}

		[DataMember]
		public string VerenigingNaam
		{
			get
			{
				return this.VerenigingNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingNaamField, value))
				{
					this.VerenigingNaamField = value;
					this.RaisePropertyChanged("VerenigingNaam");
				}
			}
		}

		[DataMember]
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

		public VerenigingData()
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