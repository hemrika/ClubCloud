using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetPostcodeDetailResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetPostcodeDetailResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private string GemeenteField;

		private string HuisnummerTMField;

		private string HuisnummerVanField;

		private bool IsOnevenField;

		private string PlaatsField;

		private string StraatField;

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
		public string HuisnummerTM
		{
			get
			{
				return this.HuisnummerTMField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HuisnummerTMField, value))
				{
					this.HuisnummerTMField = value;
					this.RaisePropertyChanged("HuisnummerTM");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string HuisnummerVan
		{
			get
			{
				return this.HuisnummerVanField;
			}
			set
			{
				if (!object.ReferenceEquals(this.HuisnummerVanField, value))
				{
					this.HuisnummerVanField = value;
					this.RaisePropertyChanged("HuisnummerVan");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public bool IsOneven
		{
			get
			{
				return this.IsOnevenField;
			}
			set
			{
				if (!this.IsOnevenField.Equals(value))
				{
					this.IsOnevenField = value;
					this.RaisePropertyChanged("IsOneven");
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

		public GetPostcodeDetailResponse()
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