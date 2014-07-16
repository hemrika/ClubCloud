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
	public class SetStateSgt_com_ploegRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegState sgt_com_ploegStateField;

		private int sgt_com_ploegStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_ploegState Sgt_com_ploegState
		{
			get
			{
				return this.sgt_com_ploegStateField;
			}
			set
			{
				this.sgt_com_ploegStateField = value;
				base.RaisePropertyChanged("Sgt_com_ploegState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_ploegStatus
		{
			get
			{
				return this.sgt_com_ploegStatusField;
			}
			set
			{
				this.sgt_com_ploegStatusField = value;
				base.RaisePropertyChanged("Sgt_com_ploegStatus");
			}
		}

		public SetStateSgt_com_ploegRequest()
		{
		}
	}
}