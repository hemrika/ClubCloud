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
	public class TargetCreateSgt_com_reden_niet_gespeeld : TargetCreate
	{
		private sgt_com_reden_niet_gespeeld sgt_com_reden_niet_gespeeldField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_reden_niet_gespeeld Sgt_com_reden_niet_gespeeld
		{
			get
			{
				return this.sgt_com_reden_niet_gespeeldField;
			}
			set
			{
				this.sgt_com_reden_niet_gespeeldField = value;
				base.RaisePropertyChanged("Sgt_com_reden_niet_gespeeld");
			}
		}

		public TargetCreateSgt_com_reden_niet_gespeeld()
		{
		}
	}
}