using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_irreele_rs_mutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_irreele_rs_mutatieState sgt_dss_irreele_rs_mutatieStateField;
		private int sgt_dss_irreele_rs_mutatieStatusField;
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
		public Sgt_dss_irreele_rs_mutatieState Sgt_dss_irreele_rs_mutatieState
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieStateField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieStateField = value;
			}
		}
		public int Sgt_dss_irreele_rs_mutatieStatus
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieStatusField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieStatusField = value;
			}
		}
	}
}
