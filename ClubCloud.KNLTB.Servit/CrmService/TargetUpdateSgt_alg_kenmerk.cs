using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_kenmerk : TargetUpdate
	{
		private sgt_alg_kenmerk sgt_alg_kenmerkField;
		public sgt_alg_kenmerk Sgt_alg_kenmerk
		{
			get
			{
				return this.sgt_alg_kenmerkField;
			}
			set
			{
				this.sgt_alg_kenmerkField = value;
			}
		}
	}
}