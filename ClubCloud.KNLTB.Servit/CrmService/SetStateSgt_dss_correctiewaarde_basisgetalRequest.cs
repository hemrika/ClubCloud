using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_correctiewaarde_basisgetalRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_correctiewaarde_basisgetalState sgt_dss_correctiewaarde_basisgetalStateField;
		private int sgt_dss_correctiewaarde_basisgetalStatusField;
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
		public Sgt_dss_correctiewaarde_basisgetalState Sgt_dss_correctiewaarde_basisgetalState
		{
			get
			{
				return this.sgt_dss_correctiewaarde_basisgetalStateField;
			}
			set
			{
				this.sgt_dss_correctiewaarde_basisgetalStateField = value;
			}
		}
		public int Sgt_dss_correctiewaarde_basisgetalStatus
		{
			get
			{
				return this.sgt_dss_correctiewaarde_basisgetalStatusField;
			}
			set
			{
				this.sgt_dss_correctiewaarde_basisgetalStatusField = value;
			}
		}
	}
}
