using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekVerenigingenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekVerenigingenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid? DistrictIdField;

		private string PlaatsField;

		private string PostcodeTotEnMetField;

		private string PostcodeVanafField;

		private string VerenigingsNaamField;

		private string VerenigingsNummerField;

		[DataMember(IsRequired=true)]
		public Guid? DistrictId
		{
			get
			{
				return this.DistrictIdField;
			}
			set
			{
				if (!this.DistrictIdField.Equals(value))
				{
					this.DistrictIdField = value;
					this.RaisePropertyChanged("DistrictId");
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
		public string Plaats
		{
			get
			{
				return this.PlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlaatsField, value))
				{
					this.PlaatsField = value;
					this.RaisePropertyChanged("Plaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PostcodeTotEnMet
		{
			get
			{
				return this.PostcodeTotEnMetField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostcodeTotEnMetField, value))
				{
					this.PostcodeTotEnMetField = value;
					this.RaisePropertyChanged("PostcodeTotEnMet");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string PostcodeVanaf
		{
			get
			{
				return this.PostcodeVanafField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostcodeVanafField, value))
				{
					this.PostcodeVanafField = value;
					this.RaisePropertyChanged("PostcodeVanaf");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string VerenigingsNaam
		{
			get
			{
				return this.VerenigingsNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsNaamField, value))
				{
					this.VerenigingsNaamField = value;
					this.RaisePropertyChanged("VerenigingsNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
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

		public ZoekVerenigingenRequest()
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