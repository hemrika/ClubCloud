using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateIncidentResolutionRequest : Request
	{
		private Guid entityIdField;
		private IncidentResolutionState incidentResolutionStateField;
		private int incidentResolutionStatusField;
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
		public IncidentResolutionState IncidentResolutionState
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
		[XmlElement(Order = 2)]
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
	}
}
