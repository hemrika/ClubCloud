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
	public class SetStateSgt_com_deelname_niet_knltb_lidRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_deelname_niet_knltb_lidState sgt_com_deelname_niet_knltb_lidStateField;

		private int sgt_com_deelname_niet_knltb_lidStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_com_deelname_niet_knltb_lidState Sgt_com_deelname_niet_knltb_lidState
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidStateField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidStateField = value;
				base.RaisePropertyChanged("Sgt_com_deelname_niet_knltb_lidState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_com_deelname_niet_knltb_lidStatus
		{
			get
			{
				return this.sgt_com_deelname_niet_knltb_lidStatusField;
			}
			set
			{
				this.sgt_com_deelname_niet_knltb_lidStatusField = value;
				base.RaisePropertyChanged("Sgt_com_deelname_niet_knltb_lidStatus");
			}
		}

		public SetStateSgt_com_deelname_niet_knltb_lidRequest()
		{
		}
	}
}