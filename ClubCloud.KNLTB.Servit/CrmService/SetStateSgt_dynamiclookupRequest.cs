using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dynamiclookupRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dynamiclookupState sgt_dynamiclookupStateField;
		private int sgt_dynamiclookupStatusField;
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
		public Sgt_dynamiclookupState Sgt_dynamiclookupState
		{
			get
			{
				return this.sgt_dynamiclookupStateField;
			}
			set
			{
				this.sgt_dynamiclookupStateField = value;
			}
		}
		public int Sgt_dynamiclookupStatus
		{
			get
			{
				return this.sgt_dynamiclookupStatusField;
			}
			set
			{
				this.sgt_dynamiclookupStatusField = value;
			}
		}
	}
}
