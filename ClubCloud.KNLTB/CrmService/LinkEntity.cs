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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class LinkEntity : INotifyPropertyChanged
	{
		private string linkFromAttributeNameField;

		private string linkFromEntityNameField;

		private string linkToEntityNameField;

		private string linkToAttributeNameField;

		private ClubCloud.KNLTB.ServIt.CrmService.JoinOperator joinOperatorField;

		private FilterExpression linkCriteriaField;

		private LinkEntity[] linkEntitiesField;

		[XmlElement] //[XmlElement(Order=4)]
		public ClubCloud.KNLTB.ServIt.CrmService.JoinOperator JoinOperator
		{
			get
			{
				return this.joinOperatorField;
			}
			set
			{
				this.joinOperatorField = value;
				this.RaisePropertyChanged("JoinOperator");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public FilterExpression LinkCriteria
		{
			get
			{
				return this.linkCriteriaField;
			}
			set
			{
				this.linkCriteriaField = value;
				this.RaisePropertyChanged("LinkCriteria");
			}
		}

		[XmlArray] //[XmlArray(Order=6)]
		[XmlArrayItem(IsNullable=false)]
		public LinkEntity[] LinkEntities
		{
			get
			{
				return this.linkEntitiesField;
			}
			set
			{
				this.linkEntitiesField = value;
				this.RaisePropertyChanged("LinkEntities");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public string LinkFromAttributeName
		{
			get
			{
				return this.linkFromAttributeNameField;
			}
			set
			{
				this.linkFromAttributeNameField = value;
				this.RaisePropertyChanged("LinkFromAttributeName");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string LinkFromEntityName
		{
			get
			{
				return this.linkFromEntityNameField;
			}
			set
			{
				this.linkFromEntityNameField = value;
				this.RaisePropertyChanged("LinkFromEntityName");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public string LinkToAttributeName
		{
			get
			{
				return this.linkToAttributeNameField;
			}
			set
			{
				this.linkToAttributeNameField = value;
				this.RaisePropertyChanged("LinkToAttributeName");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public string LinkToEntityName
		{
			get
			{
				return this.linkToEntityNameField;
			}
			set
			{
				this.linkToEntityNameField = value;
				this.RaisePropertyChanged("LinkToEntityName");
			}
		}

		public LinkEntity()
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