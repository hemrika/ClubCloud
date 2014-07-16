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
	public class SetStateSgt_dss_tussentijdse_rating_peildatumRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_tussentijdse_rating_peildatumState sgt_dss_tussentijdse_rating_peildatumStateField;

		private int sgt_dss_tussentijdse_rating_peildatumStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sgt_dss_tussentijdse_rating_peildatumState Sgt_dss_tussentijdse_rating_peildatumState
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumStateField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumStateField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_rating_peildatumState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sgt_dss_tussentijdse_rating_peildatumStatus
		{
			get
			{
				return this.sgt_dss_tussentijdse_rating_peildatumStatusField;
			}
			set
			{
				this.sgt_dss_tussentijdse_rating_peildatumStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_rating_peildatumStatus");
			}
		}

		public SetStateSgt_dss_tussentijdse_rating_peildatumRequest()
		{
		}
	}
}