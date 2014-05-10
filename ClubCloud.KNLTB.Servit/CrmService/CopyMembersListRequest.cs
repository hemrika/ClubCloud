using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CopyMembersListRequest : Request
	{
		private Guid sourceListIdField;
		private Guid targetListIdField;
		public Guid SourceListId
		{
			get
			{
				return this.sourceListIdField;
			}
			set
			{
				this.sourceListIdField = value;
			}
		}
		public Guid TargetListId
		{
			get
			{
				return this.targetListIdField;
			}
			set
			{
				this.targetListIdField = value;
			}
		}
	}
}
