using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_factuurgroep : TargetUpdate
	{
		private sgt_fac_factuurgroep sgt_fac_factuurgroepField;
		public sgt_fac_factuurgroep Sgt_fac_factuurgroep
		{
			get
			{
				return this.sgt_fac_factuurgroepField;
			}
			set
			{
				this.sgt_fac_factuurgroepField = value;
			}
		}
	}
}
