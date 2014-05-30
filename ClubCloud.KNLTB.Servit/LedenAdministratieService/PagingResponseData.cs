using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="PagingResponseData", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Wcf")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class PagingResponseData : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool MoreRecordsField;

		[OptionalField]
		private string PagingCookieField;

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
		public bool MoreRecords
		{
			get
			{
				return this.MoreRecordsField;
			}
			set
			{
				if (!this.MoreRecordsField.Equals(value))
				{
					this.MoreRecordsField = value;
					this.RaisePropertyChanged("MoreRecords");
				}
			}
		}

		[DataMember]
		public string PagingCookie
		{
			get
			{
				return this.PagingCookieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PagingCookieField, value))
				{
					this.PagingCookieField = value;
					this.RaisePropertyChanged("PagingCookie");
				}
			}
		}

		public PagingResponseData()
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