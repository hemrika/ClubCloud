using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetUpdateSgt_toe_toernooischema_per_schemagrootte : TargetUpdate
	{
		private sgt_toe_toernooischema_per_schemagrootte sgt_toe_toernooischema_per_schemagrootteField;
		public sgt_toe_toernooischema_per_schemagrootte Sgt_toe_toernooischema_per_schemagrootte
		{
			get
			{
				return this.sgt_toe_toernooischema_per_schemagrootteField;
			}
			set
			{
				this.sgt_toe_toernooischema_per_schemagrootteField = value;
			}
		}
	}
}
