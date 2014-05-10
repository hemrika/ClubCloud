using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class SetStateIncidentRequest : Request
	{
		private Guid entityIdField;
		private IncidentState incidentStateField;
		private int incidentStatusField;
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
		public IncidentState IncidentState
		{
			get
			{
				return this.incidentStateField;
			}
			set
			{
				this.incidentStateField = value;
			}
		}
		public int IncidentStatus
		{
			get
			{
				return this.incidentStatusField;
			}
			set
			{
				this.incidentStatusField = value;
			}
		}
	}
}
