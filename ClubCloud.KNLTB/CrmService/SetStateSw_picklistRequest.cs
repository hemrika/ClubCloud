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
	public class SetStateSw_picklistRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.Sw_picklistState sw_picklistStateField;

		private int sw_picklistStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.Sw_picklistState Sw_picklistState
		{
			get
			{
				return this.sw_picklistStateField;
			}
			set
			{
				this.sw_picklistStateField = value;
				base.RaisePropertyChanged("Sw_picklistState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int Sw_picklistStatus
		{
			get
			{
				return this.sw_picklistStatusField;
			}
			set
			{
				this.sw_picklistStatusField = value;
				base.RaisePropertyChanged("Sw_picklistStatus");
			}
		}

		public SetStateSw_picklistRequest()
		{
		}
	}
}