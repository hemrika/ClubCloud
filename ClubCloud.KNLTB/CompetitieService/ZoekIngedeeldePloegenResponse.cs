using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="ZoekIngedeeldePloegenResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekIngedeeldePloegenResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private ClubCloud.KNLTB.ServIt.CompetitieService.AfdelingPloegen[] AfdelingPloegenField;

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.CompetitieService.AfdelingPloegen[] AfdelingPloegen
		{
			get
			{
				return this.AfdelingPloegenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AfdelingPloegenField, value))
				{
					this.AfdelingPloegenField = value;
					this.RaisePropertyChanged("AfdelingPloegen");
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

		public ZoekIngedeeldePloegenResponse()
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