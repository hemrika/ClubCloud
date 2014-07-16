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
	public class TargetCreateSgt_com_kalender : TargetCreate
	{
		private sgt_com_kalender sgt_com_kalenderField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_kalender Sgt_com_kalender
		{
			get
			{
				return this.sgt_com_kalenderField;
			}
			set
			{
				this.sgt_com_kalenderField = value;
				base.RaisePropertyChanged("Sgt_com_kalender");
			}
		}

		public TargetCreateSgt_com_kalender()
		{
		}
	}
}