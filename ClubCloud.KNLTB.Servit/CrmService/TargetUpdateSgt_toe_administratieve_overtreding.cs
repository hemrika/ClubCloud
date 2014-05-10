using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_administratieve_overtreding : TargetUpdate
	{
		private sgt_toe_administratieve_overtreding sgt_toe_administratieve_overtredingField;
		public sgt_toe_administratieve_overtreding Sgt_toe_administratieve_overtreding
		{
			get
			{
				return this.sgt_toe_administratieve_overtredingField;
			}
			set
			{
				this.sgt_toe_administratieve_overtredingField = value;
			}
		}
	}
}
