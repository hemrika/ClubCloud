using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_circuitranglijst_logboek : TargetCreate
	{
		private sgt_toe_circuitranglijst_logboek sgt_toe_circuitranglijst_logboekField;
		public sgt_toe_circuitranglijst_logboek Sgt_toe_circuitranglijst_logboek
		{
			get
			{
				return this.sgt_toe_circuitranglijst_logboekField;
			}
			set
			{
				this.sgt_toe_circuitranglijst_logboekField = value;
			}
		}
	}
}
