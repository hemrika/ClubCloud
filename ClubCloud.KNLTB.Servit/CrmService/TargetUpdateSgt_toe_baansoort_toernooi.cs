using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_baansoort_toernooi : TargetUpdate
	{
		private sgt_toe_baansoort_toernooi sgt_toe_baansoort_toernooiField;
		public sgt_toe_baansoort_toernooi Sgt_toe_baansoort_toernooi
		{
			get
			{
				return this.sgt_toe_baansoort_toernooiField;
			}
			set
			{
				this.sgt_toe_baansoort_toernooiField = value;
			}
		}
	}
}
