using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_mutatie_leden : TargetUpdate
	{
		private sgt_alg_pb_mutatie_leden sgt_alg_pb_mutatie_ledenField;
		public sgt_alg_pb_mutatie_leden Sgt_alg_pb_mutatie_leden
		{
			get
			{
				return this.sgt_alg_pb_mutatie_ledenField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_ledenField = value;
			}
		}
	}
}
