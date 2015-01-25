using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="SpelersProfielRating", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class SpelersProfielRating : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.Geslacht GeslachtField;

		private string NaamField;

		private decimal? RatingDubbelField;

		private decimal? RatingEnkelField;

		private int? SpeelsterkteDubbelField;

		private int? SpeelsterkteEnkelField;

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
		public decimal? RatingDubbel
		{
			get
			{
				return this.RatingDubbelField;
			}
			set
			{
				if (!this.RatingDubbelField.Equals(value))
				{
					this.RatingDubbelField = value;
					this.RaisePropertyChanged("RatingDubbel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public decimal? RatingEnkel
		{
			get
			{
				return this.RatingEnkelField;
			}
			set
			{
				if (!this.RatingEnkelField.Equals(value))
				{
					this.RatingEnkelField = value;
					this.RaisePropertyChanged("RatingEnkel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int? SpeelsterkteDubbel
		{
			get
			{
				return this.SpeelsterkteDubbelField;
			}
			set
			{
				if (!this.SpeelsterkteDubbelField.Equals(value))
				{
					this.SpeelsterkteDubbelField = value;
					this.RaisePropertyChanged("SpeelsterkteDubbel");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public int? SpeelsterkteEnkel
		{
			get
			{
				return this.SpeelsterkteEnkelField;
			}
			set
			{
				if (!this.SpeelsterkteEnkelField.Equals(value))
				{
					this.SpeelsterkteEnkelField = value;
					this.RaisePropertyChanged("SpeelsterkteEnkel");
				}
			}
		}

		public SpelersProfielRating()
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