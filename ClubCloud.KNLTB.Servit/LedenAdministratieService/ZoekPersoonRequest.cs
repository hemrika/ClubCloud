using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekPersoonRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekPersoonRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		private string BondsnummerGebruikerField;

		private Guid EvenementIdField;

		private string NaamField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.PagingRequestData PagingRequestDataField;

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

		[DataMember(IsRequired=true)]
		public string BondsnummerGebruiker
		{
			get
			{
				return this.BondsnummerGebruikerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerGebruikerField, value))
				{
					this.BondsnummerGebruikerField = value;
					this.RaisePropertyChanged("BondsnummerGebruiker");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid EvenementId
		{
			get
			{
				return this.EvenementIdField;
			}
			set
			{
				if (!this.EvenementIdField.Equals(value))
				{
					this.EvenementIdField = value;
					this.RaisePropertyChanged("EvenementId");
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
		public string Naam
		{
			get
			{
				return this.NaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamField, value))
				{
					this.NaamField = value;
					this.RaisePropertyChanged("Naam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.PagingRequestData PagingRequestData
		{
			get
			{
				return this.PagingRequestDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PagingRequestDataField, value))
				{
					this.PagingRequestDataField = value;
					this.RaisePropertyChanged("PagingRequestData");
				}
			}
		}

		public ZoekPersoonRequest()
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