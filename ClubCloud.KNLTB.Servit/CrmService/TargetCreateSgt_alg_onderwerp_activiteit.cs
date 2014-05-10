using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_onderwerp_activiteit : TargetCreate
	{
		private sgt_alg_onderwerp_activiteit sgt_alg_onderwerp_activiteitField;
		public sgt_alg_onderwerp_activiteit Sgt_alg_onderwerp_activiteit
		{
			get
			{
				return this.sgt_alg_onderwerp_activiteitField;
			}
			set
			{
				this.sgt_alg_onderwerp_activiteitField = value;
			}
		}
	}
}
