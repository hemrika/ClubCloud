using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RollupRequest : Request
	{
		private TargetRollup targetField;
		private RollupType rollupTypeField;
		private bool returnDynamicEntitiesField;
		public TargetRollup Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
			}
		}
		public RollupType RollupType
		{
			get
			{
				return this.rollupTypeField;
			}
			set
			{
				this.rollupTypeField = value;
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
