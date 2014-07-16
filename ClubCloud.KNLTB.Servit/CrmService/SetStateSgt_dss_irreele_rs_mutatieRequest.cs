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
	public class SetStateSgt_dss_irreele_rs_mutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_irreele_rs_mutatieState sgt_dss_irreele_rs_mutatieStateField;

		private int sgt_dss_irreele_rs_mutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_irreele_rs_mutatieState Sgt_dss_irreele_rs_mutatieState
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieStateField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieStateField = value;
				base.RaisePropertyChanged("Sgt_dss_irreele_rs_mutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_irreele_rs_mutatieStatus
		{
			get
			{
				return this.sgt_dss_irreele_rs_mutatieStatusField;
			}
			set
			{
				this.sgt_dss_irreele_rs_mutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_irreele_rs_mutatieStatus");
			}
		}

		public SetStateSgt_dss_irreele_rs_mutatieRequest()
		{
		}
	}
}