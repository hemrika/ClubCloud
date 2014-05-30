using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="Klassengroep", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Klassengroep : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid IdField;

		private string KlassegroepPiramideField;

		private string OmschrijvingField;

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
		public string KlassegroepPiramide
		{
			get
			{
				return this.KlassegroepPiramideField;
			}
			set
			{
				if (!object.ReferenceEquals(this.KlassegroepPiramideField, value))
				{
					this.KlassegroepPiramideField = value;
					this.RaisePropertyChanged("KlassegroepPiramide");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Omschrijving
		{
			get
			{
				return this.OmschrijvingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OmschrijvingField, value))
				{
					this.OmschrijvingField = value;
					this.RaisePropertyChanged("Omschrijving");
				}
			}
		}

		public Klassengroep()
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