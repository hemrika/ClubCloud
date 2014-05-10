using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_tussentijdse_rating_logboek : TargetCreate
	{
		private sgt_dss_tussentijdse_rating_logboek sgt_dss_tussentijdse_rating_logboekField;
		public sgt_dss_tussentijdse_rating_logboek Sgt_dss_tussentijdse_rating_logboek
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_logboekField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_logboekField = value;
			}
		}
	}
}
