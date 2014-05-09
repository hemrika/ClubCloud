using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class TargetCreateSgt_toe_toernooischema_per_schemagrootte : TargetCreate
	{
		private sgt_toe_toernooischema_per_schemagrootte sgt_toe_toernooischema_per_schemagrootteField;
		[XmlElement(Order = 0)]
		public sgt_toe_toernooischema_per_schemagrootte Sgt_toe_toernooischema_per_schemagrootte
		{
			get
			{
				return this.sgt_toe_toernooischema_per_schemagrootteField;
			}
			set
			{
				this.sgt_toe_toernooischema_per_schemagrootteField = value;
				base.RaisePropertyChanged("Sgt_toe_toernooischema_per_schemagrootte");
			}
		}
	}
}
