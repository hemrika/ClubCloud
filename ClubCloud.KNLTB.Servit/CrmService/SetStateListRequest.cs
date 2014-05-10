using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateListRequest : Request
	{
		private Guid entityIdField;
		private ListState listStateField;
		private int listStatusField;
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
		public ListState ListState
		{
			get
			{
				return this.listStateField;
			}
			set
			{
				this.listStateField = value;
			}
		}
		public int ListStatus
		{
			get
			{
				return this.listStatusField;
			}
			set
			{
				this.listStatusField = value;
			}
		}
	}
}
