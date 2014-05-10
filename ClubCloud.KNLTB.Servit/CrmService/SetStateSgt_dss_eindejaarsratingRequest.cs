using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSgt_dss_eindejaarsratingRequest : Request
	{
		private Guid entityIdField;
		private Sgt_dss_eindejaarsratingState sgt_dss_eindejaarsratingStateField;
		private int sgt_dss_eindejaarsratingStatusField;
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
		public Sgt_dss_eindejaarsratingState Sgt_dss_eindejaarsratingState
		{
			get
			{
				return this.sgt_dss_eindejaarsratingStateField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingStateField = value;
			}
		}
		public int Sgt_dss_eindejaarsratingStatus
		{
			get
			{
				return this.sgt_dss_eindejaarsratingStatusField;
			}
			set
			{
				this.sgt_dss_eindejaarsratingStatusField = value;
			}
		}
	}
}
