using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateKbArticleRequest : Request
	{
		private Guid entityIdField;
		private KbArticleState kbArticleStateField;
		private int kbArticleStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public KbArticleState KbArticleState
		{
			get
			{
				return this.kbArticleStateField;
			}
			set
			{
				this.kbArticleStateField = value;
			}
		}
		public int KbArticleStatus
		{
			get
			{
				return this.kbArticleStatusField;
			}
			set
			{
				this.kbArticleStatusField = value;
			}
		}
	}
}
