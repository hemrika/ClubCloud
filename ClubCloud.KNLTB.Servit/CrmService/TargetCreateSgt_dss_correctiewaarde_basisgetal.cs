using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_dss_correctiewaarde_basisgetal : TargetCreate
	{
		private sgt_dss_correctiewaarde_basisgetal sgt_dss_correctiewaarde_basisgetalField;
		public sgt_dss_correctiewaarde_basisgetal Sgt_dss_correctiewaarde_basisgetal
		{
			get
			{
				return this.sgt_dss_correctiewaarde_basisgetalField;
			}
			set
			{
				this.sgt_dss_correctiewaarde_basisgetalField = value;
			}
		}
	}
}
