using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetStandenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetStandenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid AfdelingVerenigingPloegIdField;

		private Guid? CompetitieIdField;

		private GetStandenRequestFilter FilterField;

		[DataMember]
		public Guid AfdelingVerenigingPloegId
		{
			get
			{
				return this.AfdelingVerenigingPloegIdField;
			}
			set
			{
				if (!this.AfdelingVerenigingPloegIdField.Equals(value))
				{
					this.AfdelingVerenigingPloegIdField = value;
					this.RaisePropertyChanged("AfdelingVerenigingPloegId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid? CompetitieId
		{
			get
			{
				return this.CompetitieIdField;
			}
			set
			{
				if (!this.CompetitieIdField.Equals(value))
				{
					this.CompetitieIdField = value;
					this.RaisePropertyChanged("CompetitieId");
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

		[DataMember(IsRequired=true)]
		public GetStandenRequestFilter Filter
		{
			get
			{
				return this.FilterField;
			}
			set
			{
				if (!this.FilterField.Equals(value))
				{
					this.FilterField = value;
					this.RaisePropertyChanged("Filter");
				}
			}
		}

		public GetStandenRequest()
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