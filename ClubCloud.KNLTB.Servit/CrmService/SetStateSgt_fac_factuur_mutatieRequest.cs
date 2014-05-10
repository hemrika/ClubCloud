using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_fac_factuur_mutatieRequest : Request
	{
		private Guid entityIdField;
		private Sgt_fac_factuur_mutatieState sgt_fac_factuur_mutatieStateField;
		private int sgt_fac_factuur_mutatieStatusField;
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
		public Sgt_fac_factuur_mutatieState Sgt_fac_factuur_mutatieState
		{
			get
			{
				return this.sgt_fac_factuur_mutatieStateField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieStateField = value;
			}
		}
		public int Sgt_fac_factuur_mutatieStatus
		{
			get
			{
				return this.sgt_fac_factuur_mutatieStatusField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieStatusField = value;
			}
		}
	}
}
