using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_ronde_poule : TargetUpdate
	{
		private sgt_toe_ronde_poule sgt_toe_ronde_pouleField;
		public sgt_toe_ronde_poule Sgt_toe_ronde_poule
		{
			get
			{
				return this.sgt_toe_ronde_pouleField;
			}
			set
			{
				this.sgt_toe_ronde_pouleField = value;
			}
		}
	}
}
