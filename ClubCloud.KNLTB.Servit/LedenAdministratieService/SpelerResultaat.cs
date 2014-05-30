using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="SpelerResultaat", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class SpelerResultaat : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		[OptionalField]
		private string BondsnummerPartnerField;

		[OptionalField]
		private decimal? BonuspuntenField;

		[OptionalField]
		private int? DSSField;

		[OptionalField]
		private int? DSSPartnerField;

		[OptionalField]
		private DateTime? GeboortedatumField;

		[OptionalField]
		private DateTime? GeboortedatumPartnerField;

		private string NaamField;

		[OptionalField]
		private string NaamPartnerField;

		[OptionalField]
		private int? PlaatsTMField;

		[OptionalField]
		private int? PlaatsVanafField;

		[OptionalField]
		private int? RanglijstPuntenField;

		[OptionalField]
		private decimal? RatingField;

		[OptionalField]
		private decimal? RatingPartnerField;

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

		[DataMember]
		public string BondsnummerPartner
		{
			get
			{
				return this.BondsnummerPartnerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerPartnerField, value))
				{
					this.BondsnummerPartnerField = value;
					this.RaisePropertyChanged("BondsnummerPartner");
				}
			}
		}

		[DataMember]
		public decimal? Bonuspunten
		{
			get
			{
				return this.BonuspuntenField;
			}
			set
			{
				if (!this.BonuspuntenField.Equals(value))
				{
					this.BonuspuntenField = value;
					this.RaisePropertyChanged("Bonuspunten");
				}
			}
		}

		[DataMember]
		public int? DSS
		{
			get
			{
				return this.DSSField;
			}
			set
			{
				if (!this.DSSField.Equals(value))
				{
					this.DSSField = value;
					this.RaisePropertyChanged("DSS");
				}
			}
		}

		[DataMember]
		public int? DSSPartner
		{
			get
			{
				return this.DSSPartnerField;
			}
			set
			{
				if (!this.DSSPartnerField.Equals(value))
				{
					this.DSSPartnerField = value;
					this.RaisePropertyChanged("DSSPartner");
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

		[DataMember]
		public DateTime? GeboortedatumPartner
		{
			get
			{
				return this.GeboortedatumPartnerField;
			}
			set
			{
				if (!this.GeboortedatumPartnerField.Equals(value))
				{
					this.GeboortedatumPartnerField = value;
					this.RaisePropertyChanged("GeboortedatumPartner");
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

		[DataMember]
		public string NaamPartner
		{
			get
			{
				return this.NaamPartnerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamPartnerField, value))
				{
					this.NaamPartnerField = value;
					this.RaisePropertyChanged("NaamPartner");
				}
			}
		}

		[DataMember]
		public int? PlaatsTM
		{
			get
			{
				return this.PlaatsTMField;
			}
			set
			{
				if (!this.PlaatsTMField.Equals(value))
				{
					this.PlaatsTMField = value;
					this.RaisePropertyChanged("PlaatsTM");
				}
			}
		}

		[DataMember]
		public int? PlaatsVanaf
		{
			get
			{
				return this.PlaatsVanafField;
			}
			set
			{
				if (!this.PlaatsVanafField.Equals(value))
				{
					this.PlaatsVanafField = value;
					this.RaisePropertyChanged("PlaatsVanaf");
				}
			}
		}

		[DataMember]
		public int? RanglijstPunten
		{
			get
			{
				return this.RanglijstPuntenField;
			}
			set
			{
				if (!this.RanglijstPuntenField.Equals(value))
				{
					this.RanglijstPuntenField = value;
					this.RaisePropertyChanged("RanglijstPunten");
				}
			}
		}

		[DataMember]
		public decimal? Rating
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
		public decimal? RatingPartner
		{
			get
			{
				return this.RatingPartnerField;
			}
			set
			{
				if (!this.RatingPartnerField.Equals(value))
				{
					this.RatingPartnerField = value;
					this.RaisePropertyChanged("RatingPartner");
				}
			}
		}

		public SpelerResultaat()
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