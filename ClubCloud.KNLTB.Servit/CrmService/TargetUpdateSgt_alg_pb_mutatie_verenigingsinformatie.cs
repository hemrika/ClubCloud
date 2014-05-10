using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pb_mutatie_verenigingsinformatie : TargetUpdate
	{
		private sgt_alg_pb_mutatie_verenigingsinformatie sgt_alg_pb_mutatie_verenigingsinformatieField;
		public sgt_alg_pb_mutatie_verenigingsinformatie Sgt_alg_pb_mutatie_verenigingsinformatie
		{
			get
			{
				return this.sgt_alg_pb_mutatie_verenigingsinformatieField;
			}
			set
			{
				this.sgt_alg_pb_mutatie_verenigingsinformatieField = value;
			}
		}
	}
}
