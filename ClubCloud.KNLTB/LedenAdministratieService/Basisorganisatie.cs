using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="Basisorganisatie", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Basisorganisatie : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid IdField;

		private string OrganisatienaamField;

		private string OrganisatienummerField;

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
		public string Organisatienaam
		{
			get
			{
				return this.OrganisatienaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatienaamField, value))
				{
					this.OrganisatienaamField = value;
					this.RaisePropertyChanged("Organisatienaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Organisatienummer
		{
			get
			{
				return this.OrganisatienummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrganisatienummerField, value))
				{
					this.OrganisatienummerField = value;
					this.RaisePropertyChanged("Organisatienummer");
				}
			}
		}

		public Basisorganisatie()
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