using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_autorisatie_entiteit_gekoppeldRequest : Request
	{
		private Guid entityIdField;
		private Sgt_autorisatie_entiteit_gekoppeldState sgt_autorisatie_entiteit_gekoppeldStateField;
		private int sgt_autorisatie_entiteit_gekoppeldStatusField;
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
		public Sgt_autorisatie_entiteit_gekoppeldState Sgt_autorisatie_entiteit_gekoppeldState
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldStateField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldStateField = value;
			}
		}
		public int Sgt_autorisatie_entiteit_gekoppeldStatus
		{
			get
			{
				return this.sgt_autorisatie_entiteit_gekoppeldStatusField;
			}
			set
			{
				this.sgt_autorisatie_entiteit_gekoppeldStatusField = value;
			}
		}
	}
}
