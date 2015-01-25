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
	public class SetStateSgt_com_reeks_speeldatumsRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_reeks_speeldatumsState sgt_com_reeks_speeldatumsStateField;

		private int sgt_com_reeks_speeldatumsStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_reeks_speeldatumsState Sgt_com_reeks_speeldatumsState
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsStateField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsStateField = value;
				base.RaisePropertyChanged("Sgt_com_reeks_speeldatumsState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_reeks_speeldatumsStatus
		{
			get
			{
				return this.sgt_com_reeks_speeldatumsStatusField;
			}
			set
			{
				this.sgt_com_reeks_speeldatumsStatusField = value;
				base.RaisePropertyChanged("Sgt_com_reeks_speeldatumsStatus");
			}
		}

		public SetStateSgt_com_reeks_speeldatumsRequest()
		{
		}
	}
}