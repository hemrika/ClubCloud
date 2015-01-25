using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetKlassengroepenForInschrijvingRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetKlassengroepenForInschrijvingRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid? CompetitieIdField;

		[OptionalField]
		private StatusCompetitieFilter? StatusFilterField;

		private Guid VerenigingIdField;

		[DataMember]
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

		[DataMember]
		public StatusCompetitieFilter? StatusFilter
		{
			get
			{
				return this.StatusFilterField;
			}
			set
			{
				if (!this.StatusFilterField.Equals(value))
				{
					this.StatusFilterField = value;
					this.RaisePropertyChanged("StatusFilter");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid VerenigingId
		{
			get
			{
				return this.VerenigingIdField;
			}
			set
			{
				if (!this.VerenigingIdField.Equals(value))
				{
					this.VerenigingIdField = value;
					this.RaisePropertyChanged("VerenigingId");
				}
			}
		}

		public GetKlassengroepenForInschrijvingRequest()
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