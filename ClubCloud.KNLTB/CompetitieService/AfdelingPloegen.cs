using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="AfdelingPloegen", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class AfdelingPloegen : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid AfdelingIdField;

		private string AfdelingnaamField;

		private string CompetitieField;

		private Guid CompetitieIdField;

		private IngedeeldePloeg[] IngedeeldePloegenField;

		private string KlassengroepOmschrijvingField;

		private string PiramideDagField;

		private string PiramideDagdeelField;

		private Guid PiramideIdField;

		private string PiramideNaamField;

		private string SamengesteldeNaamAfdelingField;

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
		public string Afdelingnaam
		{
			get
			{
				return this.AfdelingnaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AfdelingnaamField, value))
				{
					this.AfdelingnaamField = value;
					this.RaisePropertyChanged("Afdelingnaam");
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

		[DataMember(IsRequired=true)]
		public Guid CompetitieId
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
		public IngedeeldePloeg[] IngedeeldePloegen
		{
			get
			{
				return this.IngedeeldePloegenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IngedeeldePloegenField, value))
				{
					this.IngedeeldePloegenField = value;
					this.RaisePropertyChanged("IngedeeldePloegen");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string KlassengroepOmschrijving
		{
			get
			{
				return this.KlassengroepOmschrijvingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KlassengroepOmschrijvingField, value))
				{
					this.KlassengroepOmschrijvingField = value;
					this.RaisePropertyChanged("KlassengroepOmschrijving");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PiramideDag
		{
			get
			{
				return this.PiramideDagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PiramideDagField, value))
				{
					this.PiramideDagField = value;
					this.RaisePropertyChanged("PiramideDag");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PiramideDagdeel
		{
			get
			{
				return this.PiramideDagdeelField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PiramideDagdeelField, value))
				{
					this.PiramideDagdeelField = value;
					this.RaisePropertyChanged("PiramideDagdeel");
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
		public string PiramideNaam
		{
			get
			{
				return this.PiramideNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PiramideNaamField, value))
				{
					this.PiramideNaamField = value;
					this.RaisePropertyChanged("PiramideNaam");
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

		public AfdelingPloegen()
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