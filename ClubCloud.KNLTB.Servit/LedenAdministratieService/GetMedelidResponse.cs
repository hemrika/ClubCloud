using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetMedelidResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetMedelidResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private MedeLid[] MedeledenField;

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
		public MedeLid[] Medeleden
		{
			get
			{
				return this.MedeledenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.MedeledenField, value))
				{
					this.MedeledenField = value;
					this.RaisePropertyChanged("Medeleden");
				}
			}
		}

		public GetMedelidResponse()
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