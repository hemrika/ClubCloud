using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_logboek_VNT : TargetUpdate
	{
		private sgt_bo_logboek_vnt sgt_bo_logboek_VNTField;
		public sgt_bo_logboek_vnt Sgt_bo_logboek_VNT
		{
			get
			{
				return this.sgt_bo_logboek_VNTField;
			}
			set
			{
				this.sgt_bo_logboek_VNTField = value;
			}
		}
	}
}
