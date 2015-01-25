using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="BestuursorgaanForVereniging", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class BestuursorgaanForVereniging : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string EmailadresField;

		private string FunctieField;

		private string OrgaanField;

		private string TelefoonField;

		private string VolledigeNaamField;

		[DataMember(IsRequired=true)]
		public string Emailadres
		{
			get
			{
				return this.EmailadresField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailadresField, value))
				{
					this.EmailadresField = value;
					this.RaisePropertyChanged("Emailadres");
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
		public string Functie
		{
			get
			{
				return this.FunctieField;
			}
			set
			{
				if (!object.ReferenceEquals(this.FunctieField, value))
				{
					this.FunctieField = value;
					this.RaisePropertyChanged("Functie");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Orgaan
		{
			get
			{
				return this.OrgaanField;
			}
			set
			{
				if (!object.ReferenceEquals(this.OrgaanField, value))
				{
					this.OrgaanField = value;
					this.RaisePropertyChanged("Orgaan");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Telefoon
		{
			get
			{
				return this.TelefoonField;
			}
			set
			{
				if (!object.ReferenceEquals(this.TelefoonField, value))
				{
					this.TelefoonField = value;
					this.RaisePropertyChanged("Telefoon");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string VolledigeNaam
		{
			get
			{
				return this.VolledigeNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VolledigeNaamField, value))
				{
					this.VolledigeNaamField = value;
					this.RaisePropertyChanged("VolledigeNaam");
				}
			}
		}

		public BestuursorgaanForVereniging()
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