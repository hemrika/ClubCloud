using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetWedstrijdgegevensRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetWedstrijdgegevensRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid AfdelingVerenigingWedstrijdgegevenIdField;

		private Guid? CompetitieIdField;

		private bool DamesMeisjesField;

		private GetWedstrijdgegevensFilter FilterField;

		private bool GemengdField;

		private bool GeslachtNvtField;

		private bool HerenJongensField;

		[OptionalField]
		private DateTime? SpeeldatumTotEnMetField;

		[OptionalField]
		private DateTime? SpeeldatumVanafField;

		[DataMember]
		public Guid AfdelingVerenigingWedstrijdgegevenId
		{
			get
			{
				return this.AfdelingVerenigingWedstrijdgegevenIdField;
			}
			set
			{
				if (!this.AfdelingVerenigingWedstrijdgegevenIdField.Equals(value))
				{
					this.AfdelingVerenigingWedstrijdgegevenIdField = value;
					this.RaisePropertyChanged("AfdelingVerenigingWedstrijdgegevenId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid? CompetitieId
		{
			get
			{
				return this.CompetitieIdField;
			}
			set
			{
				if (!this.CompetitieIdField.Equals(value))
				{
					this.CompetitieIdField = value;
					this.RaisePropertyChanged("CompetitieId");
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

		[DataMember(IsRequired=true)]
		public GetWedstrijdgegevensFilter Filter
		{
			get
			{
				return this.FilterField;
			}
			set
			{
				if (!this.FilterField.Equals(value))
				{
					this.FilterField = value;
					this.RaisePropertyChanged("Filter");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool Gemengd
		{
			get
			{
				return this.GemengdField;
			}
			set
			{
				if (!this.GemengdField.Equals(value))
				{
					this.GemengdField = value;
					this.RaisePropertyChanged("Gemengd");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool GeslachtNvt
		{
			get
			{
				return this.GeslachtNvtField;
			}
			set
			{
				if (!this.GeslachtNvtField.Equals(value))
				{
					this.GeslachtNvtField = value;
					this.RaisePropertyChanged("GeslachtNvt");
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
		public DateTime? SpeeldatumTotEnMet
		{
			get
			{
				return this.SpeeldatumTotEnMetField;
			}
			set
			{
				if (!this.SpeeldatumTotEnMetField.Equals(value))
				{
					this.SpeeldatumTotEnMetField = value;
					this.RaisePropertyChanged("SpeeldatumTotEnMet");
				}
			}
		}

		[DataMember]
		public DateTime? SpeeldatumVanaf
		{
			get
			{
				return this.SpeeldatumVanafField;
			}
			set
			{
				if (!this.SpeeldatumVanafField.Equals(value))
				{
					this.SpeeldatumVanafField = value;
					this.RaisePropertyChanged("SpeeldatumVanaf");
				}
			}
		}

		public GetWedstrijdgegevensRequest()
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