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
	public class TargetCreateSgt_alg_lidmaatschappen_omhangen : TargetCreate
	{
		private sgt_alg_lidmaatschappen_omhangen sgt_alg_lidmaatschappen_omhangenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_alg_lidmaatschappen_omhangen Sgt_alg_lidmaatschappen_omhangen
		{
			get
			{
				return this.sgt_alg_lidmaatschappen_omhangenField;
			}
			set
			{
				this.sgt_alg_lidmaatschappen_omhangenField = value;
				base.RaisePropertyChanged("Sgt_alg_lidmaatschappen_omhangen");
			}
		}

		public TargetCreateSgt_alg_lidmaatschappen_omhangen()
		{
		}
	}
}