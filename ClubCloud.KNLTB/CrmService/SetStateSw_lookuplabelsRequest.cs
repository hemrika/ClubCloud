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
	public class SetStateSw_lookuplabelsRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_lookuplabelsState sw_lookuplabelsStateField;

		private int sw_lookuplabelsStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_lookuplabelsState Sw_lookuplabelsState
		{
			get
			{
				return this.sw_lookuplabelsStateField;
			}
			set
			{
				this.sw_lookuplabelsStateField = value;
				base.RaisePropertyChanged("Sw_lookuplabelsState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_lookuplabelsStatus
		{
			get
			{
				return this.sw_lookuplabelsStatusField;
			}
			set
			{
				this.sw_lookuplabelsStatusField = value;
				base.RaisePropertyChanged("Sw_lookuplabelsStatus");
			}
		}

		public SetStateSw_lookuplabelsRequest()
		{
		}
	}
}