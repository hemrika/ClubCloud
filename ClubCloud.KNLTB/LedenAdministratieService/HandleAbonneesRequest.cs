using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.LedenAdministratieService
{
	[DataContract(Name="HandleAbonneesRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class HandleAbonneesRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid PersoonIdField;

		private ClubCloud.KNLTB.ServIt.LedenAdministratieService.SoortAbonnement[] SoortAbonnementField;

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
		public Guid PersoonId
		{
			get
			{
				return this.PersoonIdField;
			}
			set
			{
				if (!this.PersoonIdField.Equals(value))
				{
					this.PersoonIdField = value;
					this.RaisePropertyChanged("PersoonId");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public ClubCloud.KNLTB.ServIt.LedenAdministratieService.SoortAbonnement[] SoortAbonnement
		{
			get
			{
				return this.SoortAbonnementField;
			}
			set
			{
				if (!object.ReferenceEquals(this.SoortAbonnementField, value))
				{
					this.SoortAbonnementField = value;
					this.RaisePropertyChanged("SoortAbonnement");
				}
			}
		}

		public HandleAbonneesRequest()
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