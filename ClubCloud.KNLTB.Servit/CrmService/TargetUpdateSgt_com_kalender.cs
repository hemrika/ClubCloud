using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_kalender : TargetUpdate
	{
		private sgt_com_kalender sgt_com_kalenderField;
		public sgt_com_kalender Sgt_com_kalender
		{
			get
			{
				return this.sgt_com_kalenderField;
			}
			set
			{
				this.sgt_com_kalenderField = value;
			}
		}
	}
}
