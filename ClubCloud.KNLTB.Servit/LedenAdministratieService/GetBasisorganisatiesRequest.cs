using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetBasisorganisatiesRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetBasisorganisatiesRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		[OptionalField]
		private bool? InclusiefAlleTypenField;

		[OptionalField]
		private bool? InclusiefVerenigingenField;

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
		public bool? InclusiefAlleTypen
		{
			get
			{
				return this.InclusiefAlleTypenField;
			}
			set
			{
				if (!this.InclusiefAlleTypenField.Equals(value))
				{
					this.InclusiefAlleTypenField = value;
					this.RaisePropertyChanged("InclusiefAlleTypen");
				}
			}
		}

		[DataMember]
		public bool? InclusiefVerenigingen
		{
			get
			{
				return this.InclusiefVerenigingenField;
			}
			set
			{
				if (!this.InclusiefVerenigingenField.Equals(value))
				{
					this.InclusiefVerenigingenField = value;
					this.RaisePropertyChanged("InclusiefVerenigingen");
				}
			}
		}

		public GetBasisorganisatiesRequest()
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