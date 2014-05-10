using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_tussentijdse_ratingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_tussentijdse_ratingState sgt_dss_tussentijdse_ratingStateField;
		private int sgt_dss_tussentijdse_ratingStatusField;
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
		public Sgt_dss_tussentijdse_ratingState Sgt_dss_tussentijdse_ratingState
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingStateField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingStateField = value;
			}
		}
		public int Sgt_dss_tussentijdse_ratingStatus
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingStatusField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingStatusField = value;
			}
		}
	}
}
