using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_alg_gebeurtenisgespreksonderwerp : TargetUpdate
	{
		private sgt_alg_gebeurtenisgespreksonderwerp sgt_alg_gebeurtenisgespreksonderwerpField;
		public sgt_alg_gebeurtenisgespreksonderwerp Sgt_alg_gebeurtenisgespreksonderwerp
		{
			get
			{
				return this.sgt_alg_gebeurtenisgespreksonderwerpField;
			}
			set
			{
				this.sgt_alg_gebeurtenisgespreksonderwerpField = value;
			}
		}
	}
}
