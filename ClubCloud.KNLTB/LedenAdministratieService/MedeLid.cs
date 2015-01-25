using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="MedeLid", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class MedeLid : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		private string EmailField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		private string NaamField;

		private string RatingField;

		private string SpeelsterkteField;

		private string TelefoonField;

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

		[DataMember(IsRequired=true)]
		public string Email
		{
			get
			{
				return this.EmailField;
			}
			set
			{
				if (!object.ReferenceEquals(this.EmailField, value))
				{
					this.EmailField = value;
					this.RaisePropertyChanged("Email");
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

		[DataMember(IsRequired=true)]
		public string Rating
		{
			get
			{
				return this.RatingField;
			}
			set
			{
				if (!object.ReferenceEquals(this.RatingField, value))
				{
					this.RatingField = value;
					this.RaisePropertyChanged("Rating");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Speelsterkte
		{
			get
			{
				return this.SpeelsterkteField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpeelsterkteField, value))
				{
					this.SpeelsterkteField = value;
					this.RaisePropertyChanged("Speelsterkte");
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

		public MedeLid()
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