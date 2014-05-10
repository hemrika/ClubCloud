using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_bo_logboek_ecampus_resultatenRequest : Request
	{
		private Guid entityIdField;
		private Sgt_bo_logboek_ecampus_resultatenState sgt_bo_logboek_ecampus_resultatenStateField;
		private int sgt_bo_logboek_ecampus_resultatenStatusField;
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
		public Sgt_bo_logboek_ecampus_resultatenState Sgt_bo_logboek_ecampus_resultatenState
		{
			get
			{
				return this.sgt_bo_logboek_ecampus_resultatenStateField;
			}
			set
			{
				this.sgt_bo_logboek_ecampus_resultatenStateField = value;
			}
		}
		public int Sgt_bo_logboek_ecampus_resultatenStatus
		{
			get
			{
				return this.sgt_bo_logboek_ecampus_resultatenStatusField;
			}
			set
			{
				this.sgt_bo_logboek_ecampus_resultatenStatusField = value;
			}
		}
	}
}
