using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_spelersprofielRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_spelersprofielState sgt_dss_spelersprofielStateField;
		private int sgt_dss_spelersprofielStatusField;
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
		public Sgt_dss_spelersprofielState Sgt_dss_spelersprofielState
		{
			get
			{
				return this.sgt_dss_spelersprofielStateField;
			}
			set
			{
				this.sgt_dss_spelersprofielStateField = value;
			}
		}
		public int Sgt_dss_spelersprofielStatus
		{
			get
			{
				return this.sgt_dss_spelersprofielStatusField;
			}
			set
			{
				this.sgt_dss_spelersprofielStatusField = value;
			}
		}
	}
}