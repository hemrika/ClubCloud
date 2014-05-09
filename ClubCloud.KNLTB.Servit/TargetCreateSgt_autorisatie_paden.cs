using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_autorisatie_paden : TargetCreate
	{
		private sgt_autorisatie_paden sgt_autorisatie_padenField;
		[XmlElement(Order = 0)]
		public sgt_autorisatie_paden Sgt_autorisatie_paden
		{
			get
			{
				return this.sgt_autorisatie_padenField;
			}
			set
			{
				this.sgt_autorisatie_padenField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_paden");
			}
		}
	}
}
