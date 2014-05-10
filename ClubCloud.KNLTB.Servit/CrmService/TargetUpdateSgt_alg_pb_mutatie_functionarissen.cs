using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_mutatie_functionarissen : TargetUpdate
	{
		private sgt_alg_pb_mutatie_functionarissen sgt_alg_pb_mutatie_functionarissenField;
		public sgt_alg_pb_mutatie_functionarissen Sgt_alg_pb_mutatie_functionarissen
		{
			get
			{
				return this.sgt_alg_pb_mutatie_functionarissenField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_functionarissenField = value;
			}
		}
	}
}
