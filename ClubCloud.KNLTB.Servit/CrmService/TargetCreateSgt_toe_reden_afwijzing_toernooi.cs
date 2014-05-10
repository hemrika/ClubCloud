using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_reden_afwijzing_toernooi : TargetCreate
	{
		private sgt_toe_reden_afwijzing_toernooi sgt_toe_reden_afwijzing_toernooiField;
		public sgt_toe_reden_afwijzing_toernooi Sgt_toe_reden_afwijzing_toernooi
		{
			get
			{
				return this.sgt_toe_reden_afwijzing_toernooiField;
			}
			set
			{
				this.sgt_toe_reden_afwijzing_toernooiField = value;
			}
		}
	}
}
