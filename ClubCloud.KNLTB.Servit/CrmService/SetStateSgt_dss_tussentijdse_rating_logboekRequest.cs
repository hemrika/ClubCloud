using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_tussentijdse_rating_logboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_tussentijdse_rating_logboekState sgt_dss_tussentijdse_rating_logboekStateField;
		private int sgt_dss_tussentijdse_rating_logboekStatusField;
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public Sgt_dss_tussentijdse_rating_logboekState Sgt_dss_tussentijdse_rating_logboekState
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_logboekStateField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_logboekStateField = value;
			}
		}
		public int Sgt_dss_tussentijdse_rating_logboekStatus
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_logboekStatusField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_logboekStatusField = value;
			}
		}
	}
}
