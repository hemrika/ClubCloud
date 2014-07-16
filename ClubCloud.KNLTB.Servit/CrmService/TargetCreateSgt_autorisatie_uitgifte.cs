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
	public class TargetCreateSgt_autorisatie_uitgifte : TargetCreate
	{
		private sgt_autorisatie_uitgifte sgt_autorisatie_uitgifteField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_autorisatie_uitgifte Sgt_autorisatie_uitgifte
		{
			get
			{
				return this.sgt_autorisatie_uitgifteField;
			}
			set
			{
				this.sgt_autorisatie_uitgifteField = value;
				base.RaisePropertyChanged("Sgt_autorisatie_uitgifte");
			}
		}

		public TargetCreateSgt_autorisatie_uitgifte()
		{
		}
	}
}