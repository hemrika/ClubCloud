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
	public class SetStateBusinessUnitRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.BusinessUnitState businessUnitStateField;

		private int businessUnitStatusField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.BusinessUnitState BusinessUnitState
		{
			get
			{
				return this.businessUnitStateField;
			}
			set
			{
				this.businessUnitStateField = value;
				base.RaisePropertyChanged("BusinessUnitState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int BusinessUnitStatus
		{
			get
			{
				return this.businessUnitStatusField;
			}
			set
			{
				this.businessUnitStatusField = value;
				base.RaisePropertyChanged("BusinessUnitStatus");
			}
		}

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

		public SetStateBusinessUnitRequest()
		{
		}
	}
}