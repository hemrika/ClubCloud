using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_boetes : TargetUpdate
	{
		private sgt_alg_boetes sgt_alg_boetesField;
		public sgt_alg_boetes Sgt_alg_boetes
		{
			get
			{
				return this.sgt_alg_boetesField;
			}
			set
			{
				this.sgt_alg_boetesField = value;
			}
		}
	}
}
