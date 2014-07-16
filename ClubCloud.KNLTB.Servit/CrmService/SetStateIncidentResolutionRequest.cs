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
	public class SetStateIncidentResolutionRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.IncidentResolutionState incidentResolutionStateField;

		private int incidentResolutionStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.IncidentResolutionState IncidentResolutionState
		{
			get
			{
				return this.incidentResolutionStateField;
			}
			set
			{
				this.incidentResolutionStateField = value;
				base.RaisePropertyChanged("IncidentResolutionState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int IncidentResolutionStatus
		{
			get
			{
				return this.incidentResolutionStatusField;
			}
			set
			{
				this.incidentResolutionStatusField = value;
				base.RaisePropertyChanged("IncidentResolutionStatus");
			}
		}

		public SetStateIncidentResolutionRequest()
		{
		}
	}
}