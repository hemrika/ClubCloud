using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_alg_vrij_bondsnummer : TargetCreate
	{
		private sgt_alg_vrij_bondsnummer sgt_alg_vrij_bondsnummerField;
		public sgt_alg_vrij_bondsnummer Sgt_alg_vrij_bondsnummer
		{
			get
			{
				return this.sgt_alg_vrij_bondsnummerField;
			}
			set
			{
				this.sgt_alg_vrij_bondsnummerField = value;
			}
		}
	}
}
