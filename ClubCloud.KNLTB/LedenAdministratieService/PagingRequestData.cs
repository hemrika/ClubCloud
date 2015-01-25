using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="PagingRequestData", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Wcf")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class PagingRequestData : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int CountField;

		[OptionalField]
		private int PageNumberField;

		[OptionalField]
		private string PagingCookieField;

		[DataMember]
		public int Count
		{
			get
			{
				return this.CountField;
			}
			set
			{
				if (!this.CountField.Equals(value))
				{
					this.CountField = value;
					this.RaisePropertyChanged("Count");
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
		public int PageNumber
		{
			get
			{
				return this.PageNumberField;
			}
			set
			{
				if (!this.PageNumberField.Equals(value))
				{
					this.PageNumberField = value;
					this.RaisePropertyChanged("PageNumber");
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

		public PagingRequestData()
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