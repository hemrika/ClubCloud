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
		public Guid EntityId
		{
			get
			{
				return this.entityIdField;
			}
			set
			{
				this.entityIdField = value;
			}
		}
		public IncidentResolutionState IncidentResolutionState
		{
			get
			{
				return this.incidentResolutionStateField;
			}
			set
			{
				this.incidentResolutionStateField = value;
			}
		}
		public int IncidentResolutionStatus
		{
			get
			{
				return this.incidentResolutionStatusField;
			}
			set
			{
				this.incidentResolutionStatusField = value;
			}
		}
	}
}
