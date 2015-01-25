using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="Adres", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Adres : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private string GemeenteField;

		private string HuisnummerField;

		private string PlaatsField;

		private string PostcodeField;

		private string StraatField;

		private string ToevoegingField;

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
		public string Gemeente
		{
			get
			{
				return this.GemeenteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.GemeenteField, value))
				{
					this.GemeenteField = value;
					this.RaisePropertyChanged("Gemeente");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Huisnummer
		{
			get
			{
				return this.HuisnummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HuisnummerField, value))
				{
					this.HuisnummerField = value;
					this.RaisePropertyChanged("Huisnummer");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Plaats
		{
			get
			{
				return this.PlaatsField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PlaatsField, value))
				{
					this.PlaatsField = value;
					this.RaisePropertyChanged("Plaats");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Postcode
		{
			get
			{
				return this.PostcodeField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PostcodeField, value))
				{
					this.PostcodeField = value;
					this.RaisePropertyChanged("Postcode");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Straat
		{
			get
			{
				return this.StraatField;
			}
			set
			{
				if (!object.ReferenceEquals(this.StraatField, value))
				{
					this.StraatField = value;
					this.RaisePropertyChanged("Straat");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Toevoeging
		{
			get
			{
				return this.ToevoegingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ToevoegingField, value))
				{
					this.ToevoegingField = value;
					this.RaisePropertyChanged("Toevoeging");
				}
			}
		}

		public Adres()
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