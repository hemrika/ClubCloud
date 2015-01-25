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
	public class SetStateSgt_com_verenigingsrechtRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_verenigingsrechtState sgt_com_verenigingsrechtStateField;

		private int sgt_com_verenigingsrechtStatusField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
				base.RaisePropertyChanged("EntityId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_verenigingsrechtState Sgt_com_verenigingsrechtState
		{
			get
			{
				return this.sgt_com_verenigingsrechtStateField;
			}
			set
			{
				this.sgt_com_verenigingsrechtStateField = value;
				base.RaisePropertyChanged("Sgt_com_verenigingsrechtState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_verenigingsrechtStatus
		{
			get
			{
				return this.sgt_com_verenigingsrechtStatusField;
			}
			set
			{
				this.sgt_com_verenigingsrechtStatusField = value;
				base.RaisePropertyChanged("Sgt_com_verenigingsrechtStatus");
			}
		}

		public SetStateSgt_com_verenigingsrechtRequest()
		{
		}
	}
}