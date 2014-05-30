using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="CreateIdealPaymentRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CreateIdealPaymentRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		[OptionalField]
		private Guid? ExamenIdField;

		private IdealPaymentFormulierType FormulierTypeField;

		[OptionalField]
		private Guid? IngedeeldeOpleidingsgroepIdField;

		[OptionalField]
		private Guid? LicentieIdField;

		[OptionalField]
		private Guid? OpleidingIdField;

		[OptionalField]
		private Guid? VoorkeurOpleidingsgroep1IdField;

		[OptionalField]
		private Guid? VoorkeurOpleidingsgroep2IdField;

		[OptionalField]
		private Guid? VoorkeurOpleidingsgroep3IdField;

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
		public Guid? ExamenId
		{
			get
			{
				return this.ExamenIdField;
			}
			set
			{
				if (!this.ExamenIdField.Equals(value))
				{
					this.ExamenIdField = value;
					this.RaisePropertyChanged("ExamenId");
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
		public IdealPaymentFormulierType FormulierType
		{
			get
			{
				return this.FormulierTypeField;
			}
			set
			{
				if (!this.FormulierTypeField.Equals(value))
				{
					this.FormulierTypeField = value;
					this.RaisePropertyChanged("FormulierType");
				}
			}
		}

		[DataMember]
		public Guid? IngedeeldeOpleidingsgroepId
		{
			get
			{
				return this.IngedeeldeOpleidingsgroepIdField;
			}
			set
			{
				if (!this.IngedeeldeOpleidingsgroepIdField.Equals(value))
				{
					this.IngedeeldeOpleidingsgroepIdField = value;
					this.RaisePropertyChanged("IngedeeldeOpleidingsgroepId");
				}
			}
		}

		[DataMember]
		public Guid? LicentieId
		{
			get
			{
				return this.LicentieIdField;
			}
			set
			{
				if (!this.LicentieIdField.Equals(value))
				{
					this.LicentieIdField = value;
					this.RaisePropertyChanged("LicentieId");
				}
			}
		}

		[DataMember]
		public Guid? OpleidingId
		{
			get
			{
				return this.OpleidingIdField;
			}
			set
			{
				if (!this.OpleidingIdField.Equals(value))
				{
					this.OpleidingIdField = value;
					this.RaisePropertyChanged("OpleidingId");
				}
			}
		}

		[DataMember]
		public Guid? VoorkeurOpleidingsgroep1Id
		{
			get
			{
				return this.VoorkeurOpleidingsgroep1IdField;
			}
			set
			{
				if (!this.VoorkeurOpleidingsgroep1IdField.Equals(value))
				{
					this.VoorkeurOpleidingsgroep1IdField = value;
					this.RaisePropertyChanged("VoorkeurOpleidingsgroep1Id");
				}
			}
		}

		[DataMember]
		public Guid? VoorkeurOpleidingsgroep2Id
		{
			get
			{
				return this.VoorkeurOpleidingsgroep2IdField;
			}
			set
			{
				if (!this.VoorkeurOpleidingsgroep2IdField.Equals(value))
				{
					this.VoorkeurOpleidingsgroep2IdField = value;
					this.RaisePropertyChanged("VoorkeurOpleidingsgroep2Id");
				}
			}
		}

		[DataMember]
		public Guid? VoorkeurOpleidingsgroep3Id
		{
			get
			{
				return this.VoorkeurOpleidingsgroep3IdField;
			}
			set
			{
				if (!this.VoorkeurOpleidingsgroep3IdField.Equals(value))
				{
					this.VoorkeurOpleidingsgroep3IdField = value;
					this.RaisePropertyChanged("VoorkeurOpleidingsgroep3Id");
				}
			}
		}

		public CreateIdealPaymentRequest()
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