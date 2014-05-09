using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_piramide : TargetCreate
	{
		private sgt_com_piramide sgt_com_piramideField;
		[XmlElement(Order = 0)]
		public sgt_com_piramide Sgt_com_piramide
		{
			get
			{
				return this.sgt_com_piramideField;
			}
			set
			{
				this.sgt_com_piramideField = value;
				base.RaisePropertyChanged("Sgt_com_piramide");
			}
		}
	}
}
