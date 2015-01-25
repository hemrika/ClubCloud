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
	public class TargetCreateSgt_dss_speelsterktemutatie_aanvraag : TargetCreate
	{
		private sgt_dss_speelsterktemutatie_aanvraag sgt_dss_speelsterktemutatie_aanvraagField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_dss_speelsterktemutatie_aanvraag Sgt_dss_speelsterktemutatie_aanvraag
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatie_aanvraag");
			}
		}

		public TargetCreateSgt_dss_speelsterktemutatie_aanvraag()
		{
		}
	}
}