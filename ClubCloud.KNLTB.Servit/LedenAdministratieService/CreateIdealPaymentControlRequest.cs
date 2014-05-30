using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="CreateIdealPaymentControlRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CreateIdealPaymentControlRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string AcceptUrlField;

		private string BondsnummerField;

		[OptionalField]
		private string CancelUrlField;

		[OptionalField]
		private string DeclineUrlField;

		[OptionalField]
		private string ExceptionUrlField;

		private string IdealBetalingRequestIdField;

		private IdealBetalingType IdealBetalingRequestTypeField;

		[DataMember]
		public string AcceptUrl
		{
			get
			{
				return this.AcceptUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AcceptUrlField, value))
				{
					this.AcceptUrlField = value;
					this.RaisePropertyChanged("AcceptUrl");
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

		[DataMember]
		public string CancelUrl
		{
			get
			{
				return this.CancelUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CancelUrlField, value))
				{
					this.CancelUrlField = value;
					this.RaisePropertyChanged("CancelUrl");
				}
			}
		}

		[DataMember]
		public string DeclineUrl
		{
			get
			{
				return this.DeclineUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DeclineUrlField, value))
				{
					this.DeclineUrlField = value;
					this.RaisePropertyChanged("DeclineUrl");
				}
			}
		}

		[DataMember]
		public string ExceptionUrl
		{
			get
			{
				return this.ExceptionUrlField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ExceptionUrlField, value))
				{
					this.ExceptionUrlField = value;
					this.RaisePropertyChanged("ExceptionUrl");
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
		public string IdealBetalingRequestId
		{
			get
			{
				return this.IdealBetalingRequestIdField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdealBetalingRequestIdField, value))
				{
					this.IdealBetalingRequestIdField = value;
					this.RaisePropertyChanged("IdealBetalingRequestId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public IdealBetalingType IdealBetalingRequestType
		{
			get
			{
				return this.IdealBetalingRequestTypeField;
			}
			set
			{
				if (!this.IdealBetalingRequestTypeField.Equals(value))
				{
					this.IdealBetalingRequestTypeField = value;
					this.RaisePropertyChanged("IdealBetalingRequestType");
				}
			}
		}

		public CreateIdealPaymentControlRequest()
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