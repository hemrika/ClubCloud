using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class MergeRequest : Request
	{
		private TargetMerge targetField;
		private Guid subordinateIdField;
		private BusinessEntity updateContentField;
		private bool performParentingChecksField;
		public TargetMerge Target
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
		public Guid SubordinateId
		{
			get
			{
				return this.subordinateIdField;
			}
			set
			{
				this.subordinateIdField = value;
			}
		}
		public BusinessEntity UpdateContent
		{
			get
			{
				return this.updateContentField;
			}
			set
			{
				this.updateContentField = value;
			}
		}
		public bool PerformParentingChecks
		{
			get
			{
				return this.performParentingChecksField;
			}
			set
			{
				this.performParentingChecksField = value;
			}
		}
	}
}
