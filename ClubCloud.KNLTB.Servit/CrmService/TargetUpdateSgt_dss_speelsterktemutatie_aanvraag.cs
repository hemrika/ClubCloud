using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_dss_speelsterktemutatie_aanvraag : TargetUpdate
	{
		private sgt_dss_speelsterktemutatie_aanvraag sgt_dss_speelsterktemutatie_aanvraagField;
		public sgt_dss_speelsterktemutatie_aanvraag Sgt_dss_speelsterktemutatie_aanvraag
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagField = value;
			}
		}
	}
}