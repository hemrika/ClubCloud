using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_top_groep_deelnemers : TargetUpdate
	{
		private sgt_top_groep_deelnemers sgt_top_groep_deelnemersField;
		[XmlElement(Order = 0)]
		public sgt_top_groep_deelnemers Sgt_top_groep_deelnemers
		{
			get
			{
				return this.sgt_top_groep_deelnemersField;
			}
			set
			{
				this.sgt_top_groep_deelnemersField = value;
				base.RaisePropertyChanged("Sgt_top_groep_deelnemers");
			}
		}
	}
}
