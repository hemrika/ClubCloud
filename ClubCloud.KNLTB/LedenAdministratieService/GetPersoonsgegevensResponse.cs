using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetPersoonsgegevensResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetPersoonsgegevensResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Persoonsgegevens PersoonsgegevensField;

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
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Persoonsgegevens Persoonsgegevens
		{
			get
			{
				return this.PersoonsgegevensField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PersoonsgegevensField, value))
				{
					this.PersoonsgegevensField = value;
					this.RaisePropertyChanged("Persoonsgegevens");
				}
			}
		}

		public GetPersoonsgegevensResponse()
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