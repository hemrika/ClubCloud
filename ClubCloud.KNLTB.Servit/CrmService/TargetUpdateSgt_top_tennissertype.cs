using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_top_tennissertype : TargetUpdate
	{
		private sgt_top_tennissertype sgt_top_tennissertypeField;
		public sgt_top_tennissertype Sgt_top_tennissertype
		{
			get
			{
				return this.sgt_top_tennissertypeField;
			}
			set
			{
				this.sgt_top_tennissertypeField = value;
			}
		}
	}
}
