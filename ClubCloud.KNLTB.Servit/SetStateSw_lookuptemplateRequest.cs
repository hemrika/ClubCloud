using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateSw_lookuptemplateRequest : Request
	{
		private Guid entityIdField;
		private Sw_lookuptemplateState sw_lookuptemplateStateField;
		private int sw_lookuptemplateStatusField;
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
		public Sw_lookuptemplateState Sw_lookuptemplateState
		{
			get
			{
				return this.sw_lookuptemplateStateField;
			}
			set
			{
				this.sw_lookuptemplateStateField = value;
				base.RaisePropertyChanged("Sw_lookuptemplateState");
			}
		}
		[XmlElement(Order = 2)]
		public int Sw_lookuptemplateStatus
		{
			get
			{
				return this.sw_lookuptemplateStatusField;
			}
			set
			{
				this.sw_lookuptemplateStatusField = value;
				base.RaisePropertyChanged("Sw_lookuptemplateStatus");
			}
		}
	}
}
