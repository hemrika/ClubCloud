using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="GetSpelersprofielResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class GetSpelersprofielResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		[OptionalField]
		private bool? AlleenToernooienVoorInschrijfperiodeField;

		[OptionalField]
		private Guid? DefaultToernooisoortIdField;

		[OptionalField]
		private TypeInschrijving? DefaultTypeInschrijvingField;

		private bool IsEenSpelerField;

		[DataMember]
		public bool? AlleenToernooienVoorInschrijfperiode
		{
			get
			{
				return this.AlleenToernooienVoorInschrijfperiodeField;
			}
			set
			{
				if (!this.AlleenToernooienVoorInschrijfperiodeField.Equals(value))
				{
					this.AlleenToernooienVoorInschrijfperiodeField = value;
					this.RaisePropertyChanged("AlleenToernooienVoorInschrijfperiode");
				}
			}
		}

		[DataMember]
		public Guid? DefaultToernooisoortId
		{
			get
			{
				return this.DefaultToernooisoortIdField;
			}
			set
			{
				if (!this.DefaultToernooisoortIdField.Equals(value))
				{
					this.DefaultToernooisoortIdField = value;
					this.RaisePropertyChanged("DefaultToernooisoortId");
				}
			}
		}

		[DataMember]
		public TypeInschrijving? DefaultTypeInschrijving
		{
			get
			{
				return this.DefaultTypeInschrijvingField;
			}
			set
			{
				if (!this.DefaultTypeInschrijvingField.Equals(value))
				{
					this.DefaultTypeInschrijvingField = value;
					this.RaisePropertyChanged("DefaultTypeInschrijving");
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
		public bool IsEenSpeler
		{
			get
			{
				return this.IsEenSpelerField;
			}
			set
			{
				if (!this.IsEenSpelerField.Equals(value))
				{
					this.IsEenSpelerField = value;
					this.RaisePropertyChanged("IsEenSpeler");
				}
			}
		}

		public GetSpelersprofielResponse()
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