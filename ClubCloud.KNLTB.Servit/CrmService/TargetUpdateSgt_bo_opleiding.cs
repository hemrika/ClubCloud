using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_opleiding : TargetUpdate
	{
		private sgt_bo_opleiding sgt_bo_opleidingField;
		public sgt_bo_opleiding Sgt_bo_opleiding
		{
			get
			{
				return this.sgt_bo_opleidingField;
			}
			set
			{
				this.sgt_bo_opleidingField = value;
			}
		}
	}
}