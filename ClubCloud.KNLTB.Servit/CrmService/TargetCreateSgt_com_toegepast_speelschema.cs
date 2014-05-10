using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_com_toegepast_speelschema : TargetCreate
	{
		private sgt_com_toegepast_speelschema sgt_com_toegepast_speelschemaField;
		public sgt_com_toegepast_speelschema Sgt_com_toegepast_speelschema
		{
			get
			{
				return this.sgt_com_toegepast_speelschemaField;
			}
			set
			{
				this.sgt_com_toegepast_speelschemaField = value;
			}
		}
	}
}
