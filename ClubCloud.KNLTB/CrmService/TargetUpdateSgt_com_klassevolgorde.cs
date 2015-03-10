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
	public class TargetUpdateSgt_com_klassevolgorde : TargetUpdate
	{
		private sgt_com_klassevolgorde sgt_com_klassevolgordeField;

		[XmlElement] //[XmlElement(Order=0)]
		public sgt_com_klassevolgorde Sgt_com_klassevolgorde
		{
			get
			{
				return this.sgt_com_klassevolgordeField;
			}
			set
			{
				this.sgt_com_klassevolgordeField = value;
				base.RaisePropertyChanged("Sgt_com_klassevolgorde");
			}
		}

		public TargetUpdateSgt_com_klassevolgorde()
		{
		}
	}
}