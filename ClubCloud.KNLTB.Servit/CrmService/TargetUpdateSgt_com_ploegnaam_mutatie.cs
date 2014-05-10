using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_com_ploegnaam_mutatie : TargetUpdate
	{
		private sgt_com_ploegnaam_mutatie sgt_com_ploegnaam_mutatieField;
		public sgt_com_ploegnaam_mutatie Sgt_com_ploegnaam_mutatie
		{
			get
			{
				return this.sgt_com_ploegnaam_mutatieField;
			}
			set
			{
				this.sgt_com_ploegnaam_mutatieField = value;
			}
		}
	}
}
