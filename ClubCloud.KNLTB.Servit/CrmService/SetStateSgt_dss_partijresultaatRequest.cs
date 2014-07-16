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
	public class SetStateSgt_dss_partijresultaatRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_partijresultaatState sgt_dss_partijresultaatStateField;

		private int sgt_dss_partijresultaatStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_partijresultaatState Sgt_dss_partijresultaatState
		{
			get
			{
				return this.sgt_dss_partijresultaatStateField;
			}
			set
			{
				this.sgt_dss_partijresultaatStateField = value;
				base.RaisePropertyChanged("Sgt_dss_partijresultaatState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_partijresultaatStatus
		{
			get
			{
				return this.sgt_dss_partijresultaatStatusField;
			}
			set
			{
				this.sgt_dss_partijresultaatStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_partijresultaatStatus");
			}
		}

		public SetStateSgt_dss_partijresultaatRequest()
		{
		}
	}
}