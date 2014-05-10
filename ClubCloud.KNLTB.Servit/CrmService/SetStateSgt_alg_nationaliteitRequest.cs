using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_nationaliteitRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_nationaliteitState sgt_alg_nationaliteitStateField;
		private int sgt_alg_nationaliteitStatusField;
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
		public Sgt_alg_nationaliteitState Sgt_alg_nationaliteitState
		{
			get
			{
				return this.sgt_alg_nationaliteitStateField;
			}
			set
			{
				this.sgt_alg_nationaliteitStateField = value;
			}
		}
		public int Sgt_alg_nationaliteitStatus
		{
			get
			{
				return this.sgt_alg_nationaliteitStatusField;
			}
			set
			{
				this.sgt_alg_nationaliteitStatusField = value;
			}
		}
	}
}
