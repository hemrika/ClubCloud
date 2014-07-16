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
	public class SetStateSw_lookupcolumnRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_lookupcolumnState sw_lookupcolumnStateField;

		private int sw_lookupcolumnStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_lookupcolumnState Sw_lookupcolumnState
		{
			get
			{
				return this.sw_lookupcolumnStateField;
			}
			set
			{
				this.sw_lookupcolumnStateField = value;
				base.RaisePropertyChanged("Sw_lookupcolumnState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_lookupcolumnStatus
		{
			get
			{
				return this.sw_lookupcolumnStatusField;
			}
			set
			{
				this.sw_lookupcolumnStatusField = value;
				base.RaisePropertyChanged("Sw_lookupcolumnStatus");
			}
		}

		public SetStateSw_lookupcolumnRequest()
		{
		}
	}
}