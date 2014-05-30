using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="HandleDuplicatenPersonenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleDuplicatenPersonenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string AchternaamField;

		[OptionalField]
		private DateTime? GeboorteDatumField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		[OptionalField]
		private string HuisnummerField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.PersoonType PersoonTypeField;

		[OptionalField]
		private string PostcodeField;

		[DataMember(IsRequired=true)]
		public string Achternaam
		{
			get
			{
				return this.AchternaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.AchternaamField, value))
				{
					this.AchternaamField = value;
					this.RaisePropertyChanged("Achternaam");
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

		[DataMember]
		public DateTime? GeboorteDatum
		{
			get
			{
				return this.GeboorteDatumField;
			}
			set
			{
				if (!this.GeboorteDatumField.Equals(value))
				{
					this.GeboorteDatumField = value;
					this.RaisePropertyChanged("GeboorteDatum");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht Geslacht
		{
			get
			{
				return this.GeslachtField;
			}
			set
			{
				if (!this.GeslachtField.Equals(value))
				{
					this.GeslachtField = value;
					this.RaisePropertyChanged("Geslacht");
				}
			}
		}

		[DataMember]
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
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.PersoonType PersoonType
		{
			get
			{
				return this.PersoonTypeField;
			}
			set
			{
				if (!this.PersoonTypeField.Equals(value))
				{
					this.PersoonTypeField = value;
					this.RaisePropertyChanged("PersoonType");
				}
			}
		}

		[DataMember]
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

		public HandleDuplicatenPersonenRequest()
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