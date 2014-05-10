using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_deelname_niet_knltb_lid : TargetCreate
	{
		private sgt_com_deelname_niet_knltb_lid sgt_com_deelname_niet_knltb_lidField;
		public sgt_com_deelname_niet_knltb_lid Sgt_com_deelname_niet_knltb_lid
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidField = value;
			}
		}
	}
}
