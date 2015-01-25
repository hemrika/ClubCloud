using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetCreateSgt_top_groep_deelnemers : TargetCreate
	{
		private sgt_top_groep_deelnemers sgt_top_groep_deelnemersField;

		[XmlElement] //[XmlElement(Order=0)]
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

		public TargetCreateSgt_top_groep_deelnemers()
		{
		}
	}
}