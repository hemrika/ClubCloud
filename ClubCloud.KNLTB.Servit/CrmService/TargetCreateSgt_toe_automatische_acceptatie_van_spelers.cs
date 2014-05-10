using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_automatische_acceptatie_van_spelers : TargetCreate
	{
		private sgt_toe_automatische_acceptatie_van_spelers sgt_toe_automatische_acceptatie_van_spelersField;
		public sgt_toe_automatische_acceptatie_van_spelers Sgt_toe_automatische_acceptatie_van_spelers
		{
			get
			{
				return this.sgt_toe_automatische_acceptatie_van_spelersField;
			}
			set
			{
				this.sgt_toe_automatische_acceptatie_van_spelersField = value;
			}
		}
	}
}
