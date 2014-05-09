using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_tussenstand_afdeling_logboek : TargetUpdate
	{
		private sgt_com_tussenstand_afdeling_logboek sgt_com_tussenstand_afdeling_logboekField;
		[XmlElement(Order = 0)]
		public sgt_com_tussenstand_afdeling_logboek Sgt_com_tussenstand_afdeling_logboek
		{
			get
			{
				return this.sgt_com_tussenstand_afdeling_logboekField;
			}
			set
			{
				this.sgt_com_tussenstand_afdeling_logboekField = value;
				base.RaisePropertyChanged("Sgt_com_tussenstand_afdeling_logboek");
			}
		}
	}
}
