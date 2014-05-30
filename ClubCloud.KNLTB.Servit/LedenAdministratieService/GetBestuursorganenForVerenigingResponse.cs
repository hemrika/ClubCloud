using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetBestuursorganenForVerenigingResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetBestuursorganenForVerenigingResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private BestuursorgaanForVereniging[] BestuursorganenField;

		private bool HasRightsForVerenigingField;

		[DataMember(IsRequired=true)]
		public BestuursorgaanForVereniging[] Bestuursorganen
		{
			get
			{
				return this.BestuursorganenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BestuursorganenField, value))
				{
					this.BestuursorganenField = value;
					this.RaisePropertyChanged("Bestuursorganen");
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
		public bool HasRightsForVereniging
		{
			get
			{
				return this.HasRightsForVerenigingField;
			}
			set
			{
				if (!this.HasRightsForVerenigingField.Equals(value))
				{
					this.HasRightsForVerenigingField = value;
					this.RaisePropertyChanged("HasRightsForVereniging");
				}
			}
		}

		public GetBestuursorganenForVerenigingResponse()
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