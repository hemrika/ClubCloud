using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_reeks_speeldatums : TargetCreate
	{
		private sgt_com_reeks_speeldatums sgt_com_reeks_speeldatumsField;
		[XmlElement(Order = 0)]
		public sgt_com_reeks_speeldatums Sgt_com_reeks_speeldatums
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsField = value;
				base.RaisePropertyChanged("Sgt_com_reeks_speeldatums");
			}
		}
	}
}
