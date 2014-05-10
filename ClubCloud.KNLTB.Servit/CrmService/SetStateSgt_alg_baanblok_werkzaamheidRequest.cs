using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_baanblok_werkzaamheidRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_baanblok_werkzaamheidState sgt_alg_baanblok_werkzaamheidStateField;
		private int sgt_alg_baanblok_werkzaamheidStatusField;
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
		public Sgt_alg_baanblok_werkzaamheidState Sgt_alg_baanblok_werkzaamheidState
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidStateField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidStateField = value;
			}
		}
		public int Sgt_alg_baanblok_werkzaamheidStatus
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidStatusField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidStatusField = value;
			}
		}
	}
}
