using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_fac_factuurverzameling : TargetCreate
	{
		private sgt_fac_factuurverzameling sgt_fac_factuurverzamelingField;
		[XmlElement(Order = 0)]
		public sgt_fac_factuurverzameling Sgt_fac_factuurverzameling
		{
			get
			{
				return this.sgt_fac_factuurverzamelingField;
			}
			set
			{
				this.sgt_fac_factuurverzamelingField = value;
				base.RaisePropertyChanged("Sgt_fac_factuurverzameling");
			}
		}
	}
}
