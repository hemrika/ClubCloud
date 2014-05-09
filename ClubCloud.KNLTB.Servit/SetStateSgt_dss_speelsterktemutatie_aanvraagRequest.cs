using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_speelsterktemutatie_aanvraagRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_speelsterktemutatie_aanvraagState sgt_dss_speelsterktemutatie_aanvraagStateField;
		private int sgt_dss_speelsterktemutatie_aanvraagStatusField;
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
		public Sgt_dss_speelsterktemutatie_aanvraagState Sgt_dss_speelsterktemutatie_aanvraagState
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagStateField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagStateField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatie_aanvraagState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sgt_dss_speelsterktemutatie_aanvraagStatus
		{
			get
			{
				return this.sgt_dss_speelsterktemutatie_aanvraagStatusField;
			}
			set
			{
				this.sgt_dss_speelsterktemutatie_aanvraagStatusField = value;
				base.RaisePropertyChanged("Sgt_dss_speelsterktemutatie_aanvraagStatus");
			}
		}
	}
}
