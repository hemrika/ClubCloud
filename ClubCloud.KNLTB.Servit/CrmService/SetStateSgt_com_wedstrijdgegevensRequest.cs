using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_wedstrijdgegevensRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_wedstrijdgegevensState sgt_com_wedstrijdgegevensStateField;
		private int sgt_com_wedstrijdgegevensStatusField;
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
		public Sgt_com_wedstrijdgegevensState Sgt_com_wedstrijdgegevensState
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensStateField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensStateField = value;
			}
		}
		public int Sgt_com_wedstrijdgegevensStatus
		{
			get
			{
				return this.sgt_com_wedstrijdgegevensStatusField;
			}
			set
			{
				this.sgt_com_wedstrijdgegevensStatusField = value;
			}
		}
	}
}
