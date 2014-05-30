using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetUserDistrictResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services.Relatiebeheer")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetUserDistrictResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string DistrictField;

		[OptionalField]
		private Guid? DistrictIdField;

		[DataMember]
		public string District
		{
			get
			{
				return this.DistrictField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DistrictField, value))
				{
					this.DistrictField = value;
					this.RaisePropertyChanged("District");
				}
			}
		}

		[DataMember]
		public Guid? DistrictId
		{
			get
			{
				return this.DistrictIdField;
			}
			set
			{
				if (!this.DistrictIdField.Equals(value))
				{
					this.DistrictIdField = value;
					this.RaisePropertyChanged("DistrictId");
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

		public GetUserDistrictResponse()
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