using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_retrievequeryRequest : Request
	{
		private Guid entityIdField;
		private Sw_retrievequeryState sw_retrievequeryStateField;
		private int sw_retrievequeryStatusField;
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
		public Sw_retrievequeryState Sw_retrievequeryState
		{
			get
			{
				return this.sw_retrievequeryStateField;
			}
			set
			{
				this.sw_retrievequeryStateField = value;
				base.RaisePropertyChanged("Sw_retrievequeryState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sw_retrievequeryStatus
		{
			get
			{
				return this.sw_retrievequeryStatusField;
			}
			set
			{
				this.sw_retrievequeryStatusField = value;
				base.RaisePropertyChanged("Sw_retrievequeryStatus");
			}
		}
	}
}
