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
	public class SetStateSgt_fac_factuur_mutatieRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuur_mutatieState sgt_fac_factuur_mutatieStateField;

		private int sgt_fac_factuur_mutatieStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_fac_factuur_mutatieState Sgt_fac_factuur_mutatieState
		{
			get
			{
				return this.sgt_fac_factuur_mutatieStateField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieStateField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_mutatieState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_fac_factuur_mutatieStatus
		{
			get
			{
				return this.sgt_fac_factuur_mutatieStatusField;
			}
			set
			{
				this.sgt_fac_factuur_mutatieStatusField = value;
				base.RaisePropertyChanged("Sgt_fac_factuur_mutatieStatus");
			}
		}

		public SetStateSgt_fac_factuur_mutatieRequest()
		{
		}
	}
}