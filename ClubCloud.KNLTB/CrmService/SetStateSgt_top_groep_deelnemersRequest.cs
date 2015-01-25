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
	public class SetStateSgt_top_groep_deelnemersRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groep_deelnemersState sgt_top_groep_deelnemersStateField;

		private int sgt_top_groep_deelnemersStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_top_groep_deelnemersState Sgt_top_groep_deelnemersState
		{
			get
			{
				return this.sgt_top_groep_deelnemersStateField;
			}
			set
			{
				this.sgt_top_groep_deelnemersStateField = value;
				base.RaisePropertyChanged("Sgt_top_groep_deelnemersState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_top_groep_deelnemersStatus
		{
			get
			{
				return this.sgt_top_groep_deelnemersStatusField;
			}
			set
			{
				this.sgt_top_groep_deelnemersStatusField = value;
				base.RaisePropertyChanged("Sgt_top_groep_deelnemersStatus");
			}
		}

		public SetStateSgt_top_groep_deelnemersRequest()
		{
		}
	}
}