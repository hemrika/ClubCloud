using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="SoortAbonnement", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class SoortAbonnement : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private bool AangevinktField;

		private string BeschrijvingField;

		private Guid IdField;

		private string NaamField;

		[DataMember(IsRequired=true)]
		public bool Aangevinkt
		{
			get
			{
				return this.AangevinktField;
			}
			set
			{
				if (!this.AangevinktField.Equals(value))
				{
					this.AangevinktField = value;
					this.RaisePropertyChanged("Aangevinkt");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Beschrijving
		{
			get
			{
				return this.BeschrijvingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BeschrijvingField, value))
				{
					this.BeschrijvingField = value;
					this.RaisePropertyChanged("Beschrijving");
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
		public Guid Id
		{
			get
			{
				return this.IdField;
			}
			set
			{
				if (!this.IdField.Equals(value))
				{
					this.IdField = value;
					this.RaisePropertyChanged("Id");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Naam
		{
			get
			{
				return this.NaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.NaamField, value))
				{
					this.NaamField = value;
					this.RaisePropertyChanged("Naam");
				}
			}
		}

		public SoortAbonnement()
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