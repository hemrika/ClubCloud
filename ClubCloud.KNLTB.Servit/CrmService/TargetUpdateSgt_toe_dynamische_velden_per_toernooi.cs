using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_dynamische_velden_per_toernooi : TargetUpdate
	{
		private sgt_toe_dynamische_velden_per_toernooi sgt_toe_dynamische_velden_per_toernooiField;
		public sgt_toe_dynamische_velden_per_toernooi Sgt_toe_dynamische_velden_per_toernooi
		{
			get
			{
				return this.sgt_toe_dynamische_velden_per_toernooiField;
			}
			set
			{
				this.sgt_toe_dynamische_velden_per_toernooiField = value;
			}
		}
	}
}