using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetSpelersProfielDetailResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetSpelersProfielDetailResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private DateTime? DatumDSSField;

		[OptionalField]
		private decimal? EindejaarsratingDubbelField;

		[OptionalField]
		private decimal? EindejaarsratingEnkelField;

		[OptionalField]
		private int? PartijResultatenDubbelDssField;

		[OptionalField]
		private int? PartijResultatenEnkelDssField;

		[OptionalField]
		private int? PartijresultatenDubbelField;

		[OptionalField]
		private int? PartijresultatenEnkelField;

		[OptionalField]
		private decimal? RatingDubbelField;

		[OptionalField]
		private decimal? RatingEnkelField;

		[OptionalField]
		private int? SpeelsterkteDubbelField;

		[OptionalField]
		private int? SpeelsterkteEnkelField;

		private string WeergaveNaamField;

		[DataMember]
		public DateTime? DatumDSS
		{
			get
			{
				return this.DatumDSSField;
			}
			set
			{
				if (!this.DatumDSSField.Equals(value))
				{
					this.DatumDSSField = value;
					this.RaisePropertyChanged("DatumDSS");
				}
			}
		}

		[DataMember]
		public decimal? EindejaarsratingDubbel
		{
			get
			{
				return this.EindejaarsratingDubbelField;
			}
			set
			{
				if (!this.EindejaarsratingDubbelField.Equals(value))
				{
					this.EindejaarsratingDubbelField = value;
					this.RaisePropertyChanged("EindejaarsratingDubbel");
				}
			}
		}

		[DataMember]
		public decimal? EindejaarsratingEnkel
		{
			get
			{
				return this.EindejaarsratingEnkelField;
			}
			set
			{
				if (!this.EindejaarsratingEnkelField.Equals(value))
				{
					this.EindejaarsratingEnkelField = value;
					this.RaisePropertyChanged("EindejaarsratingEnkel");
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
		public int? PartijresultatenDubbel
		{
			get
			{
				return this.PartijresultatenDubbelField;
			}
			set
			{
				if (!this.PartijresultatenDubbelField.Equals(value))
				{
					this.PartijresultatenDubbelField = value;
					this.RaisePropertyChanged("PartijresultatenDubbel");
				}
			}
		}

		[DataMember]
		public int? PartijResultatenDubbelDss
		{
			get
			{
				return this.PartijResultatenDubbelDssField;
			}
			set
			{
				if (!this.PartijResultatenDubbelDssField.Equals(value))
				{
					this.PartijResultatenDubbelDssField = value;
					this.RaisePropertyChanged("PartijResultatenDubbelDss");
				}
			}
		}

		[DataMember]
		public int? PartijresultatenEnkel
		{
			get
			{
				return this.PartijresultatenEnkelField;
			}
			set
			{
				if (!this.PartijresultatenEnkelField.Equals(value))
				{
					this.PartijresultatenEnkelField = value;
					this.RaisePropertyChanged("PartijresultatenEnkel");
				}
			}
		}

		[DataMember]
		public int? PartijResultatenEnkelDss
		{
			get
			{
				return this.PartijResultatenEnkelDssField;
			}
			set
			{
				if (!this.PartijResultatenEnkelDssField.Equals(value))
				{
					this.PartijResultatenEnkelDssField = value;
					this.RaisePropertyChanged("PartijResultatenEnkelDss");
				}
			}
		}

		[DataMember]
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

		[DataMember]
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

		[DataMember]
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

		[DataMember]
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

		[DataMember(IsRequired=true)]
		public string WeergaveNaam
		{
			get
			{
				return this.WeergaveNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.WeergaveNaamField, value))
				{
					this.WeergaveNaamField = value;
					this.RaisePropertyChanged("WeergaveNaam");
				}
			}
		}

		public GetSpelersProfielDetailResponse()
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