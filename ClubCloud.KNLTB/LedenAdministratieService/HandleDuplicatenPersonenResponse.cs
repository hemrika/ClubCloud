using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="HandleDuplicatenPersonenResponse", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleDuplicatenPersonenResponse : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private bool DuplicaatFoundField;

		private DuplicaatPersoon[] DuplicaatPersonenField;

		[OptionalField]
		private bool HasMoreRecordsField;

		[DataMember(IsRequired=true)]
		public bool DuplicaatFound
		{
			get
			{
				return this.DuplicaatFoundField;
			}
			set
			{
				if (!this.DuplicaatFoundField.Equals(value))
				{
					this.DuplicaatFoundField = value;
					this.RaisePropertyChanged("DuplicaatFound");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public DuplicaatPersoon[] DuplicaatPersonen
		{
			get
			{
				return this.DuplicaatPersonenField;
			}
			set
			{
				if (!object.ReferenceEquals(this.DuplicaatPersonenField, value))
				{
					this.DuplicaatPersonenField = value;
					this.RaisePropertyChanged("DuplicaatPersonen");
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
		public bool HasMoreRecords
		{
			get
			{
				return this.HasMoreRecordsField;
			}
			set
			{
				if (!this.HasMoreRecordsField.Equals(value))
				{
					this.HasMoreRecordsField = value;
					this.RaisePropertyChanged("HasMoreRecords");
				}
			}
		}

		public HandleDuplicatenPersonenResponse()
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