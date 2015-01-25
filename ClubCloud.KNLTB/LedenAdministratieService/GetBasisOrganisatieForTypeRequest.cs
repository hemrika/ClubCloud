using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetBasisOrganisatieForTypeRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetBasisOrganisatieForTypeRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.OrganisatieType OrganisatieTypeField;

		[OptionalField]
		private string VerenigingsNummerField;

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

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.OrganisatieType OrganisatieType
		{
			get
			{
				return this.OrganisatieTypeField;
			}
			set
			{
				if (!this.OrganisatieTypeField.Equals(value))
				{
					this.OrganisatieTypeField = value;
					this.RaisePropertyChanged("OrganisatieType");
				}
			}
		}

		[DataMember]
		public string VerenigingsNummer
		{
			get
			{
				return this.VerenigingsNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsNummerField, value))
				{
					this.VerenigingsNummerField = value;
					this.RaisePropertyChanged("VerenigingsNummer");
				}
			}
		}

		public GetBasisOrganisatieForTypeRequest()
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