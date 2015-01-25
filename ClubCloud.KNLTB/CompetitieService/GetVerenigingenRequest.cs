using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="GetVerenigingenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetVerenigingenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid CompetitieIdField;

		private GetVerenigingenFilter FilterField;

		[OptionalField]
		private string VerenigingsNummerField;

		[DataMember(IsRequired=true)]
		public Guid CompetitieId
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
		public GetVerenigingenFilter Filter
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

		[DataMember]
		public string VerenigingsNummer
		{
			get
			{
				return this.VerenigingsNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsNummerField, value))
				{
					this.VerenigingsNummerField = value;
					this.RaisePropertyChanged("VerenigingsNummer");
				}
			}
		}

		public GetVerenigingenRequest()
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