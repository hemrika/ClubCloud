using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_fac_factuurverzameling : TargetUpdate
	{
		private sgt_fac_factuurverzameling sgt_fac_factuurverzamelingField;
		public sgt_fac_factuurverzameling Sgt_fac_factuurverzameling
		{
			get
			{
				return this.sgt_fac_factuurverzamelingField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingField = value;
			}
		}
	}
}
