using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_toplaag : TargetCreate
	{
		private sgt_alg_toplaag sgt_alg_toplaagField;
		public sgt_alg_toplaag Sgt_alg_toplaag
		{
			get
			{
				return this.sgt_alg_toplaagField;
			}
			set
			{
				this.sgt_alg_toplaagField = value;
			}
		}
	}
}