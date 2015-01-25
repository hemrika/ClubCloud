using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetMedelidRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetMedelidRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AchternaamField;

		private string BondsnummerField;

		private bool DamesMeisjesField;

		[OptionalField]
		private int? GeboortejaarTotEnMetField;

		[OptionalField]
		private int? GeboortejaarVanafField;

		private bool HerenJongensField;

		[OptionalField]
		private decimal? RatingTotEnMetField;

		[OptionalField]
		private decimal? RatingVanafField;

		[OptionalField]
		private int? SpeelsterkteTotEnMetField;

		[OptionalField]
		private int? SpeelsterkteVanafField;

		[OptionalField]
		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Spelsoort? SpelsoortField;

		private string UsernameField;

		[OptionalField]
		private Guid? VerenigingsIdField;

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
		public int? GeboortejaarTotEnMet
		{
			get
			{
				return this.GeboortejaarTotEnMetField;
			}
			set
			{
				if (!this.GeboortejaarTotEnMetField.Equals(value))
				{
					this.GeboortejaarTotEnMetField = value;
					this.RaisePropertyChanged("GeboortejaarTotEnMet");
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
		public decimal? RatingTotEnMet
		{
			get
			{
				return this.RatingTotEnMetField;
			}
			set
			{
				if (!this.RatingTotEnMetField.Equals(value))
				{
					this.RatingTotEnMetField = value;
					this.RaisePropertyChanged("RatingTotEnMet");
				}
			}
		}

		[DataMember]
		public decimal? RatingVanaf
		{
			get
			{
				return this.RatingVanafField;
			}
			set
			{
				if (!this.RatingVanafField.Equals(value))
				{
					this.RatingVanafField = value;
					this.RaisePropertyChanged("RatingVanaf");
				}
			}
		}

		[DataMember]
		public int? SpeelsterkteTotEnMet
		{
			get
			{
				return this.SpeelsterkteTotEnMetField;
			}
			set
			{
				if (!this.SpeelsterkteTotEnMetField.Equals(value))
				{
					this.SpeelsterkteTotEnMetField = value;
					this.RaisePropertyChanged("SpeelsterkteTotEnMet");
				}
			}
		}

		[DataMember]
		public int? SpeelsterkteVanaf
		{
			get
			{
				return this.SpeelsterkteVanafField;
			}
			set
			{
				if (!this.SpeelsterkteVanafField.Equals(value))
				{
					this.SpeelsterkteVanafField = value;
					this.RaisePropertyChanged("SpeelsterkteVanaf");
				}
			}
		}

		[DataMember]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Spelsoort? Spelsoort
		{
			get
			{
				return this.SpelsoortField;
			}
			set
			{
				if (!this.SpelsoortField.Equals(value))
				{
					this.SpelsoortField = value;
					this.RaisePropertyChanged("Spelsoort");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Username
		{
			get
			{
				return this.UsernameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UsernameField, value))
				{
					this.UsernameField = value;
					this.RaisePropertyChanged("Username");
				}
			}
		}

		[DataMember]
		public Guid? VerenigingsId
		{
			get
			{
				return this.VerenigingsIdField;
			}
			set
			{
				if (!this.VerenigingsIdField.Equals(value))
				{
					this.VerenigingsIdField = value;
					this.RaisePropertyChanged("VerenigingsId");
				}
			}
		}

		public GetMedelidRequest()
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