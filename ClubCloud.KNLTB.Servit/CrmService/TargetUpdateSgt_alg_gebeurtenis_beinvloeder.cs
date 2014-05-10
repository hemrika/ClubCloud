using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_gebeurtenis_beinvloeder : TargetUpdate
	{
		private sgt_alg_gebeurtenis_beinvloeder sgt_alg_gebeurtenis_beinvloederField;
		public sgt_alg_gebeurtenis_beinvloeder Sgt_alg_gebeurtenis_beinvloeder
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederField = value;
			}
		}
	}
}
