using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_nationaliteit : TargetUpdate
	{
		private sgt_alg_nationaliteit sgt_alg_nationaliteitField;
		public sgt_alg_nationaliteit Sgt_alg_nationaliteit
		{
			get
			{
				return this.sgt_alg_nationaliteitField;
			}
			set
			{
				this.sgt_alg_nationaliteitField = value;
			}
		}
	}
}
