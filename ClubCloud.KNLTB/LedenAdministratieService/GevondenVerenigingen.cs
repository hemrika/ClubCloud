using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GevondenVerenigingen", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GevondenVerenigingen : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid? DistrictIdField;

		private Guid? IdField;

		private string PlaatsField;

		private string PostcodeField;

		private string VerenigingsNaamField;

		private string VerenigingsNummerField;

		[DataMember(IsRequired=true)]
		public Guid? DistrictId
		{
			get
			{
				return this.DistrictIdField;
			}
			set
			{
				if (!this.DistrictIdField.Equals(value))
				{
					this.DistrictIdField = value;
					this.RaisePropertyChanged("DistrictId");
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
		public Guid? Id
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
		public string VerenigingsNaam
		{
			get
			{
				return this.VerenigingsNaamField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsNaamField, value))
				{
					this.VerenigingsNaamField = value;
					this.RaisePropertyChanged("VerenigingsNaam");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string VerenigingsNummer
		{
			get
			{
				return this.VerenigingsNummerField;
			}
			set
			{
				if (!object.ReferenceEquals(this.VerenigingsNummerField, value))
				{
					this.VerenigingsNummerField = value;
					this.RaisePropertyChanged("VerenigingsNummer");
				}
			}
		}

		public GevondenVerenigingen()
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