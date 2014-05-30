using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.UserService
{
	[DataContract(Name="HandleChangePasswordRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleChangePasswordRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string CurrentPasswordField;

		[OptionalField]
		private string NewPasswordField;

		private string UserNameField;

		[DataMember(IsRequired=true)]
		public string CurrentPassword
		{
			get
			{
				return this.CurrentPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.CurrentPasswordField, value))
				{
					this.CurrentPasswordField = value;
					this.RaisePropertyChanged("CurrentPassword");
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
		public string NewPassword
		{
			get
			{
				return this.NewPasswordField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NewPasswordField, value))
				{
					this.NewPasswordField = value;
					this.RaisePropertyChanged("NewPassword");
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

		public HandleChangePasswordRequest()
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