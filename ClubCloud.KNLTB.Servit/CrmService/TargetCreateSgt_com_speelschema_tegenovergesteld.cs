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
	public class TargetCreateSgt_com_speelschema_tegenovergesteld : TargetCreate
	{
		private sgt_com_speelschema_tegenovergesteld sgt_com_speelschema_tegenovergesteldField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_speelschema_tegenovergesteld Sgt_com_speelschema_tegenovergesteld
		{
			get
			{
				return this.sgt_com_speelschema_tegenovergesteldField;
			}
			set
			{
				this.sgt_com_speelschema_tegenovergesteldField = value;
				base.RaisePropertyChanged("Sgt_com_speelschema_tegenovergesteld");
			}
		}

		public TargetCreateSgt_com_speelschema_tegenovergesteld()
		{
		}
	}
}