using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_record_lock : TargetCreate
	{
		private sgt_alg_record_lock sgt_alg_record_lockField;
		public sgt_alg_record_lock Sgt_alg_record_lock
		{
			get
			{
				return this.sgt_alg_record_lockField;
			}
			set
			{
				this.sgt_alg_record_lockField = value;
			}
		}
	}
}
