using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_bo_licentiesoort : TargetUpdate
	{
		private sgt_bo_licentiesoort sgt_bo_licentiesoortField;
		public sgt_bo_licentiesoort Sgt_bo_licentiesoort
		{
			get
			{
				return this.sgt_bo_licentiesoortField;
			}
			set
			{
				this.sgt_bo_licentiesoortField = value;
			}
		}
	}
}
