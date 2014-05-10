using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_pasfoto_bulkimport_logboek : TargetUpdate
	{
		private sgt_alg_pasfoto_bulkimport_logboek sgt_alg_pasfoto_bulkimport_logboekField;
		public sgt_alg_pasfoto_bulkimport_logboek Sgt_alg_pasfoto_bulkimport_logboek
		{
			get
			{
				return this.sgt_alg_pasfoto_bulkimport_logboekField;
			}
			set
			{
				this.sgt_alg_pasfoto_bulkimport_logboekField = value;
			}
		}
	}
}
