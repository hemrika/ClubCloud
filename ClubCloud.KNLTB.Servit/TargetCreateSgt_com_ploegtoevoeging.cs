using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_ploegtoevoeging : TargetCreate
	{
		private sgt_com_ploegtoevoeging sgt_com_ploegtoevoegingField;
		[XmlElement(Order = 0)]
		public sgt_com_ploegtoevoeging Sgt_com_ploegtoevoeging
		{
			get
			{
				return this.sgt_com_ploegtoevoegingField;
			}
			set
			{
				this.sgt_com_ploegtoevoegingField = value;
				base.RaisePropertyChanged("Sgt_com_ploegtoevoeging");
			}
		}
	}
}
