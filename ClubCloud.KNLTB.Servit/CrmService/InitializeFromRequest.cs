using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class InitializeFromRequest : Request
	{
		private Moniker entityMonikerField;
		private string targetEntityNameField;
		private TargetFieldType targetFieldTypeField;
		private bool returnDynamicEntitiesField;
		public Moniker EntityMoniker
		{
			get
			{
				return this.entityMonikerField;
			}
			set
			{
				this.entityMonikerField = value;
			}
		}
		public string TargetEntityName
		{
			get
			{
				return this.targetEntityNameField;
			}
			set
			{
				this.targetEntityNameField = value;
			}
		}
		public TargetFieldType TargetFieldType
		{
			get
			{
				return this.targetFieldTypeField;
			}
			set
			{
				this.targetFieldTypeField = value;
			}
		}
		[XmlAttribute]
		public bool ReturnDynamicEntities
		{
			get
			{
				return this.returnDynamicEntitiesField;
			}
			set
			{
				this.returnDynamicEntitiesField = value;
			}
		}
	}
}
