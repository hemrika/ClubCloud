using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="HandleIdealPaymentResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Generiek.Ideal.Service")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleIdealPaymentResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string IdealMessageField;

		private bool PaymentSuccesField;

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

		[DataMember(IsRequired=true)]
		public bool PaymentSucces
		{
			get
			{
				return this.PaymentSuccesField;
			}
			set
			{
				if (!this.PaymentSuccesField.Equals(value))
				{
					this.PaymentSuccesField = value;
					this.RaisePropertyChanged("PaymentSucces");
				}
			}
		}

		public HandleIdealPaymentResponse()
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