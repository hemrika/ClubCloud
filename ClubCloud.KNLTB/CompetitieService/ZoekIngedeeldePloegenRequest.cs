using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.Threading;

namespace ClubCloud.KNLTB.ServIt.CompetitieService
{
	[DataContract(Name="ZoekIngedeeldePloegenRequest", Namespace="http://schemas.datacontract.org/2004/07/KNLTB.ServIT2.Services")]
	[DebuggerStepThrough]
	[GeneratedCode("System.Runtime.Serialization", "4.0.0.0")]
	[Serializable]
	public class ZoekIngedeeldePloegenRequest : IExtensibleDataObject, INotifyPropertyChanged
	{
		[NonSerialized]
		private ExtensionDataObject extensionDataField;

		private Guid? CompetitieIdField;

		private ClubCloud.KNLTB.ServIt.CompetitieService.ZoekIngedeeldePloegenFilter ZoekIngedeeldePloegenFilterField;

		private string ZoekTermField;

		private string ZoekTerm2Field;

		[DataMember(IsRequired=true)]
		public Guid? CompetitieId
		{
			get
			{
				return this.CompetitieIdField;
			}
			set
			{
				if (!this.CompetitieIdField.Equals(value))
				{
					this.CompetitieIdField = value;
					this.RaisePropertyChanged("CompetitieId");
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
		public ClubCloud.KNLTB.ServIt.CompetitieService.ZoekIngedeeldePloegenFilter ZoekIngedeeldePloegenFilter
		{
			get
			{
				return this.ZoekIngedeeldePloegenFilterField;
			}
			set
			{
				if (!this.ZoekIngedeeldePloegenFilterField.Equals(value))
				{
					this.ZoekIngedeeldePloegenFilterField = value;
					this.RaisePropertyChanged("ZoekIngedeeldePloegenFilter");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ZoekTerm
		{
			get
			{
				return this.ZoekTermField;
			}
			set
			{
				if (!object.ReferenceEquals(this.ZoekTermField, value))
				{
					this.ZoekTermField = value;
					this.RaisePropertyChanged("ZoekTerm");
				}
			}
		}

		[DataMember(IsRequired=true)]
		public string ZoekTerm2
		{
			get
			{
				return this.ZoekTerm2Field;
			}
			set
			{
				if (!object.ReferenceEquals(this.ZoekTerm2Field, value))
				{
					this.ZoekTerm2Field = value;
					this.RaisePropertyChanged("ZoekTerm2");
				}
			}
		}

		public ZoekIngedeeldePloegenRequest()
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