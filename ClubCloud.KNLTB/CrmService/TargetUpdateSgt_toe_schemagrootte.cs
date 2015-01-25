using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[DebuggerStepThrough]
	[DesignerCategory("code")]
	[GeneratedCode("System.Xml", "4.0.30319.33440")]
	[Serializable]
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2007/WebServices")]
	public class TargetUpdateSgt_toe_schemagrootte : TargetUpdate
	{
		private sgt_toe_schemagrootte sgt_toe_schemagrootteField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_toe_schemagrootte Sgt_toe_schemagrootte
		{
			get
			{
				return this.sgt_toe_schemagrootteField;
			}
			set
			{
				this.sgt_toe_schemagrootteField = value;
				base.RaisePropertyChanged("Sgt_toe_schemagrootte");
			}
		}

		public TargetUpdateSgt_toe_schemagrootte()
		{
		}
	}
}