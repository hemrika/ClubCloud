using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class OrderOptionRequest : MetadataServiceRequest
	{
		private string attributeLogicalNameField;
		private string entityLogicalNameField;
		private int[] valuesField;
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
		public int[] Values
		{
			get
			{
				return this.valuesField;
			}
			set
			{
				this.valuesField = value;
			}
		}
	}
}
