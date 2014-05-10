using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_ratinglogboekRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_ratinglogboekState sgt_dss_ratinglogboekStateField;
		private int sgt_dss_ratinglogboekStatusField;
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
		public Sgt_dss_ratinglogboekState Sgt_dss_ratinglogboekState
		{
			get
			{
				return this.sgt_dss_ratinglogboekStateField;
			}
			set
			{
				this.sgt_dss_ratinglogboekStateField = value;
			}
		}
		public int Sgt_dss_ratinglogboekStatus
		{
			get
			{
				return this.sgt_dss_ratinglogboekStatusField;
			}
			set
			{
				this.sgt_dss_ratinglogboekStatusField = value;
			}
		}
	}
}
