using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_afdeling : TargetUpdate
	{
		private sgt_com_afdeling sgt_com_afdelingField;
		public sgt_com_afdeling Sgt_com_afdeling
		{
			get
			{
				return this.sgt_com_afdelingField;
			}
			set
			{
				this.sgt_com_afdelingField = value;
			}
		}
	}
}
