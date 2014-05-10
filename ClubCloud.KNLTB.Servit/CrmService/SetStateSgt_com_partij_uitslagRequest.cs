using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_partij_uitslagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_partij_uitslagState sgt_com_partij_uitslagStateField;
		private int sgt_com_partij_uitslagStatusField;
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
		public Sgt_com_partij_uitslagState Sgt_com_partij_uitslagState
		{
			get
			{
				return this.sgt_com_partij_uitslagStateField;
			}
			set
			{
				this.sgt_com_partij_uitslagStateField = value;
			}
		}
		public int Sgt_com_partij_uitslagStatus
		{
			get
			{
				return this.sgt_com_partij_uitslagStatusField;
			}
			set
			{
				this.sgt_com_partij_uitslagStatusField = value;
			}
		}
	}
}
