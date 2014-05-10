using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_alg_lookupcontrol_filterRequest : Request
	{
		private Guid entityIdField;
		private Sgt_alg_lookupcontrol_filterState sgt_alg_lookupcontrol_filterStateField;
		private int sgt_alg_lookupcontrol_filterStatusField;
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
		public Sgt_alg_lookupcontrol_filterState Sgt_alg_lookupcontrol_filterState
		{
			get
			{
				return this.sgt_alg_lookupcontrol_filterStateField;
			}
			set
			{
				this.sgt_alg_lookupcontrol_filterStateField = value;
			}
		}
		public int Sgt_alg_lookupcontrol_filterStatus
		{
			get
			{
				return this.sgt_alg_lookupcontrol_filterStatusField;
			}
			set
			{
				this.sgt_alg_lookupcontrol_filterStatusField = value;
			}
		}
	}
}
