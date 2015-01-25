using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class UpdateOptionValueRequest : MetadataServiceRequest
	{
		private string attributeLogicalNameField;
		private string entityLogicalNameField;
		private CrmLabel labelField;
		private int valueField;
		private bool mergeLabelsField;
		public string AttributeLogicalName
		{
			get
			{
				return this.attributeLogicalNameField;
			}
			set
			{
				this.attributeLogicalNameField = value;
			}
		}
		public string EntityLogicalName
		{
			get
			{
				return this.entityLogicalNameField;
			}
			set
			{
				this.entityLogicalNameField = value;
			}
		}
		public CrmLabel Label
		{
			get
			{
				return this.labelField;
			}
			set
			{
				this.labelField = value;
			}
		}
		public int Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
		public bool MergeLabels
		{
			get
			{
				return this.mergeLabelsField;
			}
			set
			{
				this.mergeLabelsField = value;
			}
		}
	}
}
