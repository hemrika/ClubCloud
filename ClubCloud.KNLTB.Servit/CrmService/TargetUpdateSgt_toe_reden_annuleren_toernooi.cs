using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_reden_annuleren_toernooi : TargetUpdate
	{
		private sgt_toe_reden_annuleren_toernooi sgt_toe_reden_annuleren_toernooiField;
		public sgt_toe_reden_annuleren_toernooi Sgt_toe_reden_annuleren_toernooi
		{
			get
			{
				return this.sgt_toe_reden_annuleren_toernooiField;
			}
			set
			{
				this.sgt_toe_reden_annuleren_toernooiField = value;
			}
		}
	}
}
