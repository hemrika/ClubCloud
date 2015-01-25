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
	public class TargetCreateSgt_alg_ad_groep : TargetCreate
	{
		private sgt_alg_ad_groep sgt_alg_ad_groepField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_ad_groep Sgt_alg_ad_groep
		{
			get
			{
				return this.sgt_alg_ad_groepField;
			}
			set
			{
				this.sgt_alg_ad_groepField = value;
				base.RaisePropertyChanged("Sgt_alg_ad_groep");
			}
		}

		public TargetCreateSgt_alg_ad_groep()
		{
		}
	}
}