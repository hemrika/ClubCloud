using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="Partijresultaat", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class Partijresultaat : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string BondsnummerThuisspelerField;

		private string BondsnummerThuisspeler2Field;

		private string BondsnummerUitspelerField;

		private string BondsnummerUitspeler2Field;

		private Guid IdField;

		private string PartijField;

		private string SetstandenField;

		private string ThuisspelerField;

		private string Thuisspeler2Field;

		private string UitslagField;

		private string UitspelerField;

		private string Uitspeler2Field;

		[DataMember(IsRequired=true)]
		public string BondsnummerThuisspeler
		{
			get
			{
				return this.BondsnummerThuisspelerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerThuisspelerField, value))
				{
					this.BondsnummerThuisspelerField = value;
					this.RaisePropertyChanged("BondsnummerThuisspeler");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsnummerThuisspeler2
		{
			get
			{
				return this.BondsnummerThuisspeler2Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerThuisspeler2Field, value))
				{
					this.BondsnummerThuisspeler2Field = value;
					this.RaisePropertyChanged("BondsnummerThuisspeler2");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsnummerUitspeler
		{
			get
			{
				return this.BondsnummerUitspelerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerUitspelerField, value))
				{
					this.BondsnummerUitspelerField = value;
					this.RaisePropertyChanged("BondsnummerUitspeler");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string BondsnummerUitspeler2
		{
			get
			{
				return this.BondsnummerUitspeler2Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.BondsnummerUitspeler2Field, value))
				{
					this.BondsnummerUitspeler2Field = value;
					this.RaisePropertyChanged("BondsnummerUitspeler2");
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
		public string Partij
		{
			get
			{
				return this.PartijField;
			}
			set
			{
				if (!object.ReferenceEquals(this.PartijField, value))
				{
					this.PartijField = value;
					this.RaisePropertyChanged("Partij");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Setstanden
		{
			get
			{
				return this.SetstandenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SetstandenField, value))
				{
					this.SetstandenField = value;
					this.RaisePropertyChanged("Setstanden");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Thuisspeler
		{
			get
			{
				return this.ThuisspelerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ThuisspelerField, value))
				{
					this.ThuisspelerField = value;
					this.RaisePropertyChanged("Thuisspeler");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Thuisspeler2
		{
			get
			{
				return this.Thuisspeler2Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.Thuisspeler2Field, value))
				{
					this.Thuisspeler2Field = value;
					this.RaisePropertyChanged("Thuisspeler2");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Uitslag
		{
			get
			{
				return this.UitslagField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UitslagField, value))
				{
					this.UitslagField = value;
					this.RaisePropertyChanged("Uitslag");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Uitspeler
		{
			get
			{
				return this.UitspelerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.UitspelerField, value))
				{
					this.UitspelerField = value;
					this.RaisePropertyChanged("Uitspeler");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string Uitspeler2
		{
			get
			{
				return this.Uitspeler2Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.Uitspeler2Field, value))
				{
					this.Uitspeler2Field = value;
					this.RaisePropertyChanged("Uitspeler2");
				}
			}
		}

		public Partijresultaat()
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