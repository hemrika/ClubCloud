using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_ploeginschrijving_afhandeling : TargetCreate
	{
		private sgt_com_ploeginschrijving_afhandeling sgt_com_ploeginschrijving_afhandelingField;
		public sgt_com_ploeginschrijving_afhandeling Sgt_com_ploeginschrijving_afhandeling
		{
			get
			{
				return this.sgt_com_ploeginschrijving_afhandelingField;
			}
			set
			{
				this.sgt_com_ploeginschrijving_afhandelingField = value;
			}
		}
	}
}
