using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_toe_toernooi_resultatenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_toe_toernooi_resultatenState sgt_toe_toernooi_resultatenStateField;
		private int sgt_toe_toernooi_resultatenStatusField;
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
		public Sgt_toe_toernooi_resultatenState Sgt_toe_toernooi_resultatenState
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenStateField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenStateField = value;
			}
		}
		public int Sgt_toe_toernooi_resultatenStatus
		{
			get
			{
				return this.sgt_toe_toernooi_resultatenStatusField;
			}
			set
			{
				this.sgt_toe_toernooi_resultatenStatusField = value;
			}
		}
	}
}
