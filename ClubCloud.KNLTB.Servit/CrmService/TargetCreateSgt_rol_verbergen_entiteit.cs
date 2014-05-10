using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_rol_verbergen_entiteit : TargetCreate
	{
		private sgt_rol_verbergen_entiteit sgt_rol_verbergen_entiteitField;
		public sgt_rol_verbergen_entiteit Sgt_rol_verbergen_entiteit
		{
			get
			{
				return this.sgt_rol_verbergen_entiteitField;
			}
			set
			{
				this.sgt_rol_verbergen_entiteitField = value;
			}
		}
	}
}
