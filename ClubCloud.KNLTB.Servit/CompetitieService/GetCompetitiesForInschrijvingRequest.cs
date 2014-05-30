using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetCompetitiesForInschrijvingRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetCompetitiesForInschrijvingRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private Guid? DistrictIdField;

		[OptionalField]
		private Guid? VerenigingIdField;

		[DataMember(EmitDefaultValue=false)]
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

		[DataMember(EmitDefaultValue=false)]
		public Guid? VerenigingId
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

		public GetCompetitiesForInschrijvingRequest()
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