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
	public class TargetCreateSgt_top_soort_groepsevenement : TargetCreate
	{
		private sgt_top_soort_groepsevenement sgt_top_soort_groepsevenementField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_top_soort_groepsevenement Sgt_top_soort_groepsevenement
		{
			get
			{
				return this.sgt_top_soort_groepsevenementField;
			}
			set
			{
				this.sgt_top_soort_groepsevenementField = value;
				base.RaisePropertyChanged("Sgt_top_soort_groepsevenement");
			}
		}

		public TargetCreateSgt_top_soort_groepsevenement()
		{
		}
	}
}