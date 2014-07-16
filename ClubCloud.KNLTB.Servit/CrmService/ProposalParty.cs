using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Scheduling")]
	public class ProposalParty : INotifyPropertyChanged
	{
		private Guid resourceIdField;

		private Guid resourceSpecIdField;

		private string displayNameField;

		private string entityNameField;

		private double effortRequiredField;

		[XmlElement] //[XmlElement(Order=2)]
		public string DisplayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
				this.RaisePropertyChanged("DisplayName");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public double EffortRequired
		{
			get
			{
				return this.effortRequiredField;
			}
			set
			{
				this.effortRequiredField = value;
				this.RaisePropertyChanged("EffortRequired");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
				this.RaisePropertyChanged("EntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
				this.RaisePropertyChanged("ResourceId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid ResourceSpecId
		{
			get
			{
				return this.resourceSpecIdField;
			}
			set
			{
				this.resourceSpecIdField = value;
				this.RaisePropertyChanged("ResourceSpecId");
			}
		}

		public ProposalParty()
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