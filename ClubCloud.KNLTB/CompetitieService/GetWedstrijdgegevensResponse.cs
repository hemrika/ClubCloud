using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetWedstrijdgegevensResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetWedstrijdgegevensResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens[] WedstrijdgegevensField;

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
		public ClubCloud.KNLTB.ServIt.CompetitieService.Wedstrijdgegevens[] Wedstrijdgegevens
		{
			get
			{
				return this.WedstrijdgegevensField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WedstrijdgegevensField, value))
				{
					this.WedstrijdgegevensField = value;
					this.RaisePropertyChanged("Wedstrijdgegevens");
				}
			}
		}

		public GetWedstrijdgegevensResponse()
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