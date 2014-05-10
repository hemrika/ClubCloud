using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_verenigingsdispensatie : TargetUpdate
	{
		private sgt_com_verenigingsdispensatie sgt_com_verenigingsdispensatieField;
		public sgt_com_verenigingsdispensatie Sgt_com_verenigingsdispensatie
		{
			get
			{
				return this.sgt_com_verenigingsdispensatieField;
			}
			set
			{
				this.sgt_com_verenigingsdispensatieField = value;
			}
		}
	}
}
