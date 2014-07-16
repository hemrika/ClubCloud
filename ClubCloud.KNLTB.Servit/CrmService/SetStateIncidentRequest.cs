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
	public class SetStateIncidentRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.IncidentState incidentStateField;

		private int incidentStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.IncidentState IncidentState
		{
			get
			{
				return this.incidentStateField;
			}
			set
			{
				this.incidentStateField = value;
				base.RaisePropertyChanged("IncidentState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int IncidentStatus
		{
			get
			{
				return this.incidentStatusField;
			}
			set
			{
				this.incidentStatusField = value;
				base.RaisePropertyChanged("IncidentStatus");
			}
		}

		public SetStateIncidentRequest()
		{
		}
	}
}