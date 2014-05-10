using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_tussentijdse_rating_peildatumRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_tussentijdse_rating_peildatumState sgt_dss_tussentijdse_rating_peildatumStateField;
		private int sgt_dss_tussentijdse_rating_peildatumStatusField;
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
		public Sgt_dss_tussentijdse_rating_peildatumState Sgt_dss_tussentijdse_rating_peildatumState
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumStateField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumStateField = value;
			}
		}
		public int Sgt_dss_tussentijdse_rating_peildatumStatus
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumStatusField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumStatusField = value;
			}
		}
	}
}
