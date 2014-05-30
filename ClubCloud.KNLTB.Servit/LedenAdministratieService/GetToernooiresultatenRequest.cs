using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetToernooiresultatenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetToernooiresultatenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		private Guid ToernooiIdField;

		private Guid ToernooiOnderdeelIdField;

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

		[DataMember(IsRequired=true)]
		public Guid ToernooiId
		{
			get
			{
				return this.ToernooiIdField;
			}
			set
			{
				if (!this.ToernooiIdField.Equals(value))
				{
					this.ToernooiIdField = value;
					this.RaisePropertyChanged("ToernooiId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public Guid ToernooiOnderdeelId
		{
			get
			{
				return this.ToernooiOnderdeelIdField;
			}
			set
			{
				if (!this.ToernooiOnderdeelIdField.Equals(value))
				{
					this.ToernooiOnderdeelIdField = value;
					this.RaisePropertyChanged("ToernooiOnderdeelId");
				}
			}
		}

		public GetToernooiresultatenRequest()
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