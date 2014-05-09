using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_Irreele_rs_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_Irreele_rs_logboekState sgt_dss_Irreele_rs_logboekStateField;
		private int sgt_dss_Irreele_rs_logboekStatusField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public Sgt_dss_Irreele_rs_logboekState Sgt_dss_Irreele_rs_logboekState
		{
			get
			{
				return this.sgt_dss_Irreele_rs_logboekStateField;
			}
			set
			{
				this.sgt_dss_Irreele_rs_logboekStateField = value;
				base.RaisePropertyChanged("Sgt_dss_Irreele_rs_logboekState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dss_Irreele_rs_logboekStatus
		{
			get
			{
				return this.sgt_dss_Irreele_rs_logboekStatusField;
			}
			set
			{
				this.sgt_dss_Irreele_rs_logboekStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_Irreele_rs_logboekStatus");
			}
		}
	}
}
