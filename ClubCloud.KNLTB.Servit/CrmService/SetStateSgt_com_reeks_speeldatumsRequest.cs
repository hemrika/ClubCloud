using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_reeks_speeldatumsRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_reeks_speeldatumsState sgt_com_reeks_speeldatumsStateField;
		private int sgt_com_reeks_speeldatumsStatusField;
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
		public Sgt_com_reeks_speeldatumsState Sgt_com_reeks_speeldatumsState
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsStateField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsStateField = value;
			}
		}
		public int Sgt_com_reeks_speeldatumsStatus
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsStatusField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsStatusField = value;
			}
		}
	}
}
