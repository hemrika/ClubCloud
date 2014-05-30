using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="UitslagAfdeling", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class UitslagAfdeling : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private DateTime? InhaaldatumField;

		[OptionalField]
		private string NaamAanvoerderField;

		[OptionalField]
		private string OndergrondField;

		[OptionalField]
		private string OpmerkingenField;

		[OptionalField]
		private string PloegThuisField;

		[OptionalField]
		private string PloegUitField;

		private string SpeeldagField;

		[OptionalField]
		private DateTime? SpeeldatumField;

		[OptionalField]
		private DateTime? TijdAanvangField;

		[OptionalField]
		private DateTime? TijdAanwezigField;

		private string UitslagField;

		[OptionalField]
		private EnumUitslag? UitslagGewonnenField;

		private string WedstrijdField;

		private Guid WedstrijdgegevenIdField;

		[OptionalField]
		private ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens WedstrijdgegevensField;

		private string WedstrijdstatusField;

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
		public DateTime? Inhaaldatum
		{
			get
			{
				return this.InhaaldatumField;
			}
			set
			{
				if (!this.InhaaldatumField.Equals(value))
				{
					this.InhaaldatumField = value;
					this.RaisePropertyChanged("Inhaaldatum");
				}
			}
		}

		[DataMember]
		public string NaamAanvoerder
		{
			get
			{
				return this.NaamAanvoerderField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamAanvoerderField, value))
				{
					this.NaamAanvoerderField = value;
					this.RaisePropertyChanged("NaamAanvoerder");
				}
			}
		}

		[DataMember]
		public string Ondergrond
		{
			get
			{
				return this.OndergrondField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OndergrondField, value))
				{
					this.OndergrondField = value;
					this.RaisePropertyChanged("Ondergrond");
				}
			}
		}

		[DataMember]
		public string Opmerkingen
		{
			get
			{
				return this.OpmerkingenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OpmerkingenField, value))
				{
					this.OpmerkingenField = value;
					this.RaisePropertyChanged("Opmerkingen");
				}
			}
		}

		[DataMember]
		public string PloegThuis
		{
			get
			{
				return this.PloegThuisField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PloegThuisField, value))
				{
					this.PloegThuisField = value;
					this.RaisePropertyChanged("PloegThuis");
				}
			}
		}

		[DataMember]
		public string PloegUit
		{
			get
			{
				return this.PloegUitField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PloegUitField, value))
				{
					this.PloegUitField = value;
					this.RaisePropertyChanged("PloegUit");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Speeldag
		{
			get
			{
				return this.SpeeldagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpeeldagField, value))
				{
					this.SpeeldagField = value;
					this.RaisePropertyChanged("Speeldag");
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

		[DataMember]
		public DateTime? TijdAanvang
		{
			get
			{
				return this.TijdAanvangField;
			}
			set
			{
				if (!this.TijdAanvangField.Equals(value))
				{
					this.TijdAanvangField = value;
					this.RaisePropertyChanged("TijdAanvang");
				}
			}
		}

		[DataMember]
		public DateTime? TijdAanwezig
		{
			get
			{
				return this.TijdAanwezigField;
			}
			set
			{
				if (!this.TijdAanwezigField.Equals(value))
				{
					this.TijdAanwezigField = value;
					this.RaisePropertyChanged("TijdAanwezig");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Uitslag
		{
			get
			{
				return this.UitslagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UitslagField, value))
				{
					this.UitslagField = value;
					this.RaisePropertyChanged("Uitslag");
				}
			}
		}

		[DataMember]
		public EnumUitslag? UitslagGewonnen
		{
			get
			{
				return this.UitslagGewonnenField;
			}
			set
			{
				if (!this.UitslagGewonnenField.Equals(value))
				{
					this.UitslagGewonnenField = value;
					this.RaisePropertyChanged("UitslagGewonnen");
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

		[DataMember(IsRequired=true)]
		public Guid WedstrijdgegevenId
		{
			get
			{
				return this.WedstrijdgegevenIdField;
			}
			set
			{
				if (!this.WedstrijdgegevenIdField.Equals(value))
				{
					this.WedstrijdgegevenIdField = value;
					this.RaisePropertyChanged("WedstrijdgegevenId");
				}
			}
		}

		[DataMember]
		public ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens Wedstrijdgegevens
		{
			get
			{
				return this.WedstrijdgegevensField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdgegevensField, value))
				{
					this.WedstrijdgegevensField = value;
					this.RaisePropertyChanged("Wedstrijdgegevens");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Wedstrijdstatus
		{
			get
			{
				return this.WedstrijdstatusField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdstatusField, value))
				{
					this.WedstrijdstatusField = value;
					this.RaisePropertyChanged("Wedstrijdstatus");
				}
			}
		}

		public UitslagAfdeling()
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