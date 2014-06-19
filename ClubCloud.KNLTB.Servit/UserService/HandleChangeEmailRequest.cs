using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.UserService
{
	[DataContract(Name="HandleChangeEmailRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleChangeEmailRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string NewEmailField;

		private string UserNameField;

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
		public string NewEmail
		{
			get
			{
				return this.NewEmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewEmailField, value))
				{
					this.NewEmailField = value;
					this.RaisePropertyChanged("NewEmail");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string UserName
		{
			get
			{
				return this.UserNameField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UserNameField, value))
				{
					this.UserNameField = value;
					this.RaisePropertyChanged("UserName");
				}
			}
		}

		public HandleChangeEmailRequest()
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