using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_baanblok_werkzaamheid : TargetCreate
	{
		private sgt_alg_baanblok_werkzaamheid sgt_alg_baanblok_werkzaamheidField;
		public sgt_alg_baanblok_werkzaamheid Sgt_alg_baanblok_werkzaamheid
		{
			get
			{
				return this.sgt_alg_baanblok_werkzaamheidField;
			}
			set
			{
				this.sgt_alg_baanblok_werkzaamheidField = value;
			}
		}
	}
}
