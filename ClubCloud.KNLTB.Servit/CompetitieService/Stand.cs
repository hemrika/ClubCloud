using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="Stand", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Stand : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private int AantalPuntenField;

		private int AantalWedstrijdenGelijkField;

		private int AantalWedstrijdenGespeeldField;

		private int AantalWedstrijdenGewonnenField;

		private int AantalWedstrijdenVerlorenField;

		private int AantalWedstrijdpuntenTegenField;

		private int AantalWedstrijdpuntenVoorField;

		[OptionalField]
		private Guid? AfdelingIdField;

		private Guid IdField;

		private Guid PiramideIdField;

		private string PloegField;

		private int PositieInStandField;

		private string SamengesteldeNaamAfdelingField;

		private Guid VerenigingIdField;

		[DataMember(IsRequired=true)]
		public int AantalPunten
		{
			get
			{
				return this.AantalPuntenField;
			}
			set
			{
				if (!this.AantalPuntenField.Equals(value))
				{
					this.AantalPuntenField = value;
					this.RaisePropertyChanged("AantalPunten");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdenGelijk
		{
			get
			{
				return this.AantalWedstrijdenGelijkField;
			}
			set
			{
				if (!this.AantalWedstrijdenGelijkField.Equals(value))
				{
					this.AantalWedstrijdenGelijkField = value;
					this.RaisePropertyChanged("AantalWedstrijdenGelijk");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdenGespeeld
		{
			get
			{
				return this.AantalWedstrijdenGespeeldField;
			}
			set
			{
				if (!this.AantalWedstrijdenGespeeldField.Equals(value))
				{
					this.AantalWedstrijdenGespeeldField = value;
					this.RaisePropertyChanged("AantalWedstrijdenGespeeld");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdenGewonnen
		{
			get
			{
				return this.AantalWedstrijdenGewonnenField;
			}
			set
			{
				if (!this.AantalWedstrijdenGewonnenField.Equals(value))
				{
					this.AantalWedstrijdenGewonnenField = value;
					this.RaisePropertyChanged("AantalWedstrijdenGewonnen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdenVerloren
		{
			get
			{
				return this.AantalWedstrijdenVerlorenField;
			}
			set
			{
				if (!this.AantalWedstrijdenVerlorenField.Equals(value))
				{
					this.AantalWedstrijdenVerlorenField = value;
					this.RaisePropertyChanged("AantalWedstrijdenVerloren");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdpuntenTegen
		{
			get
			{
				return this.AantalWedstrijdpuntenTegenField;
			}
			set
			{
				if (!this.AantalWedstrijdpuntenTegenField.Equals(value))
				{
					this.AantalWedstrijdpuntenTegenField = value;
					this.RaisePropertyChanged("AantalWedstrijdpuntenTegen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int AantalWedstrijdpuntenVoor
		{
			get
			{
				return this.AantalWedstrijdpuntenVoorField;
			}
			set
			{
				if (!this.AantalWedstrijdpuntenVoorField.Equals(value))
				{
					this.AantalWedstrijdpuntenVoorField = value;
					this.RaisePropertyChanged("AantalWedstrijdpuntenVoor");
				}
			}
		}

		[DataMember]
		public Guid? AfdelingId
		{
			get
			{
				return this.AfdelingIdField;
			}
			set
			{
				if (!this.AfdelingIdField.Equals(value))
				{
					this.AfdelingIdField = value;
					this.RaisePropertyChanged("AfdelingId");
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
		public Guid PiramideId
		{
			get
			{
				return this.PiramideIdField;
			}
			set
			{
				if (!this.PiramideIdField.Equals(value))
				{
					this.PiramideIdField = value;
					this.RaisePropertyChanged("PiramideId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Ploeg
		{
			get
			{
				return this.PloegField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PloegField, value))
				{
					this.PloegField = value;
					this.RaisePropertyChanged("Ploeg");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int PositieInStand
		{
			get
			{
				return this.PositieInStandField;
			}
			set
			{
				if (!this.PositieInStandField.Equals(value))
				{
					this.PositieInStandField = value;
					this.RaisePropertyChanged("PositieInStand");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string SamengesteldeNaamAfdeling
		{
			get
			{
				return this.SamengesteldeNaamAfdelingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SamengesteldeNaamAfdelingField, value))
				{
					this.SamengesteldeNaamAfdelingField = value;
					this.RaisePropertyChanged("SamengesteldeNaamAfdeling");
				}
			}
		}

		[DataMember(IsRequired=true)]
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

		public Stand()
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