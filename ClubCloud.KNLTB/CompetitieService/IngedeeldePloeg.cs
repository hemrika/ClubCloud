using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="IngedeeldePloeg", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class IngedeeldePloeg : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private int AantalWedstrijdenGespeeldField;

		private int AantalWedstrijdpuntenVoorField;

		private Guid AfdelingIdField;

		private string AfdelingsnaamField;

		private Guid IdField;

		private string PloegField;

		private int PloegnummerField;

		private int PositieInStandField;

		private Guid VerenigingIdField;

		private string VerenigingsnaamField;

		private string VerenigingsnummerField;

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

		[DataMember(IsRequired=true)]
		public Guid AfdelingId
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

		[DataMember(IsRequired=true)]
		public string Afdelingsnaam
		{
			get
			{
				return this.AfdelingsnaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AfdelingsnaamField, value))
				{
					this.AfdelingsnaamField = value;
					this.RaisePropertyChanged("Afdelingsnaam");
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
		public int Ploegnummer
		{
			get
			{
				return this.PloegnummerField;
			}
			set
			{
				if (!this.PloegnummerField.Equals(value))
				{
					this.PloegnummerField = value;
					this.RaisePropertyChanged("Ploegnummer");
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

		[DataMember(IsRequired=true)]
		public string Verenigingsnaam
		{
			get
			{
				return this.VerenigingsnaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsnaamField, value))
				{
					this.VerenigingsnaamField = value;
					this.RaisePropertyChanged("Verenigingsnaam");
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

		public IngedeeldePloeg()
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