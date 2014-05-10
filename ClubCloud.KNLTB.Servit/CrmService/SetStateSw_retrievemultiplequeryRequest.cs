using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_retrievemultiplequeryRequest : Request
	{
		private Guid entityIdField;
		private Sw_retrievemultiplequeryState sw_retrievemultiplequeryStateField;
		private int sw_retrievemultiplequeryStatusField;
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
		public Sw_retrievemultiplequeryState Sw_retrievemultiplequeryState
		{
			get
			{
				return this.sw_retrievemultiplequeryStateField;
			}
			set
			{
				this.sw_retrievemultiplequeryStateField = value;
			}
		}
		public int Sw_retrievemultiplequeryStatus
		{
			get
			{
				return this.sw_retrievemultiplequeryStatusField;
			}
			set
			{
				this.sw_retrievemultiplequeryStatusField = value;
			}
		}
	}
}
