using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_spelersdispensatie : TargetUpdate
	{
		private sgt_com_spelersdispensatie sgt_com_spelersdispensatieField;
		public sgt_com_spelersdispensatie Sgt_com_spelersdispensatie
		{
			get
			{
				return this.sgt_com_spelersdispensatieField;
			}
			set
			{
				this.sgt_com_spelersdispensatieField = value;
			}
		}
	}
}
