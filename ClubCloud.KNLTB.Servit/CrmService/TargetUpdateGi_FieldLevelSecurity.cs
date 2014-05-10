using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateGi_FieldLevelSecurity : TargetUpdate
	{
		private gi_fieldlevelsecurity gi_FieldLevelSecurityField;
		public gi_fieldlevelsecurity Gi_FieldLevelSecurity
		{
			get
			{
				return this.gi_FieldLevelSecurityField;
			}
			set
			{
				this.gi_FieldLevelSecurityField = value;
			}
		}
	}
}
