using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="ZoekSpelersProfielenResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekSpelersProfielenResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private bool HasMorePagesField;

		private SpelersProfielRating[] SpelersProfielenField;

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
		public bool HasMorePages
		{
			get
			{
				return this.HasMorePagesField;
			}
			set
			{
				if (!this.HasMorePagesField.Equals(value))
				{
					this.HasMorePagesField = value;
					this.RaisePropertyChanged("HasMorePages");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public SpelersProfielRating[] SpelersProfielen
		{
			get
			{
				return this.SpelersProfielenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SpelersProfielenField, value))
				{
					this.SpelersProfielenField = value;
					this.RaisePropertyChanged("SpelersProfielen");
				}
			}
		}

		public ZoekSpelersProfielenResponse()
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