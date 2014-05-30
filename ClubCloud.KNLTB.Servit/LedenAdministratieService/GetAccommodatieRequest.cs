using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetAccommodatieRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetAccommodatieRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid AccommodatieIdField;

		private string BondsnummerField;

		[DataMember(IsRequired=true)]
		public Guid AccommodatieId
		{
			get
			{
				return this.AccommodatieIdField;
			}
			set
			{
				if (!this.AccommodatieIdField.Equals(value))
				{
					this.AccommodatieIdField = value;
					this.RaisePropertyChanged("AccommodatieId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Bondsnummer
		{
			get
			{
				return this.BondsnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerField, value))
				{
					this.BondsnummerField = value;
					this.RaisePropertyChanged("Bondsnummer");
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

		public GetAccommodatieRequest()
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