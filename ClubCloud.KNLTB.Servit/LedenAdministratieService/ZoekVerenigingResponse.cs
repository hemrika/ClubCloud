using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekVerenigingResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekVerenigingResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.VerenigingNaamNummer[] VerenigingNaamNummerField;

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
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.VerenigingNaamNummer[] VerenigingNaamNummer
		{
			get
			{
				return this.VerenigingNaamNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingNaamNummerField, value))
				{
					this.VerenigingNaamNummerField = value;
					this.RaisePropertyChanged("VerenigingNaamNummer");
				}
			}
		}

		public ZoekVerenigingResponse()
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