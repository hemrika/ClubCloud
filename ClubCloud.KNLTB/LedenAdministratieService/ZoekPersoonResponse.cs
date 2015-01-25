using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekPersoonResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekPersoonResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.NaamBondsnummer[] NaamBondsnummerField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.PagingResponseData PagingResponseDataField;

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
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.NaamBondsnummer[] NaamBondsnummer
		{
			get
			{
				return this.NaamBondsnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamBondsnummerField, value))
				{
					this.NaamBondsnummerField = value;
					this.RaisePropertyChanged("NaamBondsnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.PagingResponseData PagingResponseData
		{
			get
			{
				return this.PagingResponseDataField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PagingResponseDataField, value))
				{
					this.PagingResponseDataField = value;
					this.RaisePropertyChanged("PagingResponseData");
				}
			}
		}

		public ZoekPersoonResponse()
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