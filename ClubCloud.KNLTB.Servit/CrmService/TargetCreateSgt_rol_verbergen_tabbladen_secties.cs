using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_rol_verbergen_tabbladen_secties : TargetCreate
	{
		private sgt_rol_verbergen_tabbladen_secties sgt_rol_verbergen_tabbladen_sectiesField;
		public sgt_rol_verbergen_tabbladen_secties Sgt_rol_verbergen_tabbladen_secties
		{
			get
			{
				return this.sgt_rol_verbergen_tabbladen_sectiesField;
			}
			set
			{
				this.sgt_rol_verbergen_tabbladen_sectiesField = value;
			}
		}
	}
}
