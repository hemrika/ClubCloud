using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_piramide : TargetUpdate
	{
		private sgt_com_piramide sgt_com_piramideField;
		public sgt_com_piramide Sgt_com_piramide
		{
			get
			{
				return this.sgt_com_piramideField;
			}
			set
			{
				this.sgt_com_piramideField = value;
			}
		}
	}
}