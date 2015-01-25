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
	public class SetStateSgt_com_partij_uitslagRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_partij_uitslagState sgt_com_partij_uitslagStateField;

		private int sgt_com_partij_uitslagStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_partij_uitslagState Sgt_com_partij_uitslagState
		{
			get
			{
				return this.sgt_com_partij_uitslagStateField;
			}
			set
			{
				this.sgt_com_partij_uitslagStateField = value;
				base.RaisePropertyChanged("Sgt_com_partij_uitslagState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_partij_uitslagStatus
		{
			get
			{
				return this.sgt_com_partij_uitslagStatusField;
			}
			set
			{
				this.sgt_com_partij_uitslagStatusField = value;
				base.RaisePropertyChanged("Sgt_com_partij_uitslagStatus");
			}
		}

		public SetStateSgt_com_partij_uitslagRequest()
		{
		}
	}
}