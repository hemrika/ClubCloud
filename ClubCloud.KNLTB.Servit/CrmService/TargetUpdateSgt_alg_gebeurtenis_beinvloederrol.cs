using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_gebeurtenis_beinvloederrol : TargetUpdate
	{
		private sgt_alg_gebeurtenis_beinvloederrol sgt_alg_gebeurtenis_beinvloederrolField;
		public sgt_alg_gebeurtenis_beinvloederrol Sgt_alg_gebeurtenis_beinvloederrol
		{
			get
			{
				return this.sgt_alg_gebeurtenis_beinvloederrolField;
			}
			set
			{
				this.sgt_alg_gebeurtenis_beinvloederrolField = value;
			}
		}
	}
}
