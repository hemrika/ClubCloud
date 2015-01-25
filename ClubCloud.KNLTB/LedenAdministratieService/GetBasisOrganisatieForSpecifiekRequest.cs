using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetBasisOrganisatieForSpecifiekRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetBasisOrganisatieForSpecifiekRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid? BasisorganisatieIdField;

		private string BondsnummerField;

		[OptionalField]
		private string VerenigingsnummerField;

		[DataMember]
		public Guid? BasisorganisatieId
		{
			get
			{
				return this.BasisorganisatieIdField;
			}
			set
			{
				if (!this.BasisorganisatieIdField.Equals(value))
				{
					this.BasisorganisatieIdField = value;
					this.RaisePropertyChanged("BasisorganisatieId");
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

		public GetBasisOrganisatieForSpecifiekRequest()
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