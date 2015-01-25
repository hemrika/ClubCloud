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
	public class SetStateSgt_com_spelersdispensatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_spelersdispensatieState sgt_com_spelersdispensatieStateField;

		private int sgt_com_spelersdispensatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_spelersdispensatieState Sgt_com_spelersdispensatieState
		{
			get
			{
				return this.sgt_com_spelersdispensatieStateField;
			}
			set
			{
				this.sgt_com_spelersdispensatieStateField = value;
				base.RaisePropertyChanged("Sgt_com_spelersdispensatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_spelersdispensatieStatus
		{
			get
			{
				return this.sgt_com_spelersdispensatieStatusField;
			}
			set
			{
				this.sgt_com_spelersdispensatieStatusField = value;
				base.RaisePropertyChanged("Sgt_com_spelersdispensatieStatus");
			}
		}

		public SetStateSgt_com_spelersdispensatieRequest()
		{
		}
	}
}