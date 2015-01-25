using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="CreateIdealPaymentResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class CreateIdealPaymentResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid? IdealBetalingRequestIdField;

		[OptionalField]
		private IdealBetalingType IdealBetalingRequestTypeField;

		[OptionalField]
		private string IdealMessageField;

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
		public Guid? IdealBetalingRequestId
		{
			get
			{
				return this.IdealBetalingRequestIdField;
			}
			set
			{
				if (!this.IdealBetalingRequestIdField.Equals(value))
				{
					this.IdealBetalingRequestIdField = value;
					this.RaisePropertyChanged("IdealBetalingRequestId");
				}
			}
		}

		[DataMember]
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

		[DataMember]
		public string IdealMessage
		{
			get
			{
				return this.IdealMessageField;
			}
			set
			{
				if (!object.ReferenceEquals(this.IdealMessageField, value))
				{
					this.IdealMessageField = value;
					this.RaisePropertyChanged("IdealMessage");
				}
			}
		}

		public CreateIdealPaymentResponse()
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