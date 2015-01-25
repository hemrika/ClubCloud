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
	public class TargetCreateSgt_com_aantal_afdelingen : TargetCreate
	{
		private sgt_com_aantal_afdelingen sgt_com_aantal_afdelingenField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_aantal_afdelingen Sgt_com_aantal_afdelingen
		{
			get
			{
				return this.sgt_com_aantal_afdelingenField;
			}
			set
			{
				this.sgt_com_aantal_afdelingenField = value;
				base.RaisePropertyChanged("Sgt_com_aantal_afdelingen");
			}
		}

		public TargetCreateSgt_com_aantal_afdelingen()
		{
		}
	}
}