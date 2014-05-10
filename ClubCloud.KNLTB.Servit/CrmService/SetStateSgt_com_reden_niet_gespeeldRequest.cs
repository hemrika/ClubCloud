using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_com_reden_niet_gespeeldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_com_reden_niet_gespeeldState sgt_com_reden_niet_gespeeldStateField;
		private int sgt_com_reden_niet_gespeeldStatusField;
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
		public Sgt_com_reden_niet_gespeeldState Sgt_com_reden_niet_gespeeldState
		{
			get
			{
				return this.sgt_com_reden_niet_gespeeldStateField;
			}
			set
			{
				this.sgt_com_reden_niet_gespeeldStateField = value;
			}
		}
		public int Sgt_com_reden_niet_gespeeldStatus
		{
			get
			{
				return this.sgt_com_reden_niet_gespeeldStatusField;
			}
			set
			{
				this.sgt_com_reden_niet_gespeeldStatusField = value;
			}
		}
	}
}
