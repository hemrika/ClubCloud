using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Query")]
	[Serializable]
	public class LinkEntity
	{
		private string linkFromAttributeNameField;
		private string linkFromEntityNameField;
		private string linkToEntityNameField;
		private string linkToAttributeNameField;
		private JoinOperator joinOperatorField;
		private FilterExpression linkCriteriaField;
		private LinkEntity[] linkEntitiesField;
		public string LinkFromAttributeName
		{
			get
			{
				return this.linkFromAttributeNameField;
			}
			set
			{
				this.linkFromAttributeNameField = value;
			}
		}
		public string LinkFromEntityName
		{
			get
			{
				return this.linkFromEntityNameField;
			}
			set
			{
				this.linkFromEntityNameField = value;
			}
		}
		public string LinkToEntityName
		{
			get
			{
				return this.linkToEntityNameField;
			}
			set
			{
				this.linkToEntityNameField = value;
			}
		}
		public string LinkToAttributeName
		{
			get
			{
				return this.linkToAttributeNameField;
			}
			set
			{
				this.linkToAttributeNameField = value;
			}
		}
		public JoinOperator JoinOperator
		{
			get
			{
				return this.joinOperatorField;
			}
			set
			{
				this.joinOperatorField = value;
			}
		}
		public FilterExpression LinkCriteria
		{
			get
			{
				return this.linkCriteriaField;
			}
			set
			{
				this.linkCriteriaField = value;
			}
		}
		[XmlArrayItem(IsNullable = false)]
		public LinkEntity[] LinkEntities
		{
			get
			{
				return this.linkEntitiesField;
			}
			set
			{
				this.linkEntitiesField = value;
			}
		}
	}
}
