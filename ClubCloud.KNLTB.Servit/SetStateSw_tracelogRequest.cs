using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_tracelogRequest : Request
	{
		private Guid entityIdField;
		private Sw_tracelogState sw_tracelogStateField;
		private int sw_tracelogStatusField;
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
		public Sw_tracelogState Sw_tracelogState
		{
			get
			{
				return this.sw_tracelogStateField;
			}
			set
			{
				this.sw_tracelogStateField = value;
				base.RaisePropertyChanged("Sw_tracelogState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sw_tracelogStatus
		{
			get
			{
				return this.sw_tracelogStatusField;
			}
			set
			{
				this.sw_tracelogStatusField = value;
				base.RaisePropertyChanged("Sw_tracelogStatus");
			}
		}
	}
}
