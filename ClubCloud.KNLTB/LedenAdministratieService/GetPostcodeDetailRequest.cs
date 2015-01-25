using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetPostcodeDetailRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetPostcodeDetailRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private int? HuisnummerField;

		private string PostcodeField;

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
		public int? Huisnummer
		{
			get
			{
				return this.HuisnummerField;
			}
			set
			{
				if (!this.HuisnummerField.Equals(value))
				{
					this.HuisnummerField = value;
					this.RaisePropertyChanged("Huisnummer");
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

		public GetPostcodeDetailRequest()
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