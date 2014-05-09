using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_tussentijdse_ratingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_tussentijdse_ratingState sgt_dss_tussentijdse_ratingStateField;
		private int sgt_dss_tussentijdse_ratingStatusField;
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
		public Sgt_dss_tussentijdse_ratingState Sgt_dss_tussentijdse_ratingState
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingStateField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingStateField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_ratingState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dss_tussentijdse_ratingStatus
		{
			get
			{
				return this.sgt_dss_tussentijdse_ratingStatusField;
			}
			set
			{
				this.sgt_dss_tussentijdse_ratingStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_tussentijdse_ratingStatus");
			}
		}
	}
}
