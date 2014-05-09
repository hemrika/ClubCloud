using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ProposalParty : INotifyPropertyChanged
	{
		private Guid resourceIdField;
		private Guid resourceSpecIdField;
		private string displayNameField;
		private string entityNameField;
		private double effortRequiredField;
		public event PropertyChangedEventHandler PropertyChanged;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
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
		[XmlElement(Order = 2)]
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
		[XmlElement(Order = 3)]
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
		[XmlElement(Order = 4)]
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
		protected void RaisePropertyChanged(string propertyName)
		{
			PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
