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
	public class SetStateSgt_wt_inschrijfformulier_vcl_vtlRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_inschrijfformulier_vcl_vtlState sgt_wt_inschrijfformulier_vcl_vtlStateField;

		private int sgt_wt_inschrijfformulier_vcl_vtlStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_wt_inschrijfformulier_vcl_vtlState Sgt_wt_inschrijfformulier_vcl_vtlState
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlStateField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlStateField = value;
				base.RaisePropertyChanged("Sgt_wt_inschrijfformulier_vcl_vtlState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_wt_inschrijfformulier_vcl_vtlStatus
		{
			get
			{
				return this.sgt_wt_inschrijfformulier_vcl_vtlStatusField;
			}
			set
			{
				this.sgt_wt_inschrijfformulier_vcl_vtlStatusField = value;
				base.RaisePropertyChanged("Sgt_wt_inschrijfformulier_vcl_vtlStatus");
			}
		}

		public SetStateSgt_wt_inschrijfformulier_vcl_vtlRequest()
		{
		}
	}
}