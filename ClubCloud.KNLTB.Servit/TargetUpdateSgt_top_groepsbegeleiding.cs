using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_top_groepsbegeleiding : TargetUpdate
	{
		private sgt_top_groepsbegeleiding sgt_top_groepsbegeleidingField;
		[XmlElement(Order = 0)]
		public sgt_top_groepsbegeleiding Sgt_top_groepsbegeleiding
		{
			get
			{
				return this.sgt_top_groepsbegeleidingField;
			}
			set
			{
				this.sgt_top_groepsbegeleidingField = value;
				base.RaisePropertyChanged("Sgt_top_groepsbegeleiding");
			}
		}
	}
}
