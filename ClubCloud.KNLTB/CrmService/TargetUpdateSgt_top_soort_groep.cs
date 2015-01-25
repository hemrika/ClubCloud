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
	public class TargetUpdateSgt_top_soort_groep : TargetUpdate
	{
		private sgt_top_soort_groep sgt_top_soort_groepField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_top_soort_groep Sgt_top_soort_groep
		{
			get
			{
				return this.sgt_top_soort_groepField;
			}
			set
			{
				this.sgt_top_soort_groepField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groep");
			}
		}

		public TargetUpdateSgt_top_soort_groep()
		{
		}
	}
}