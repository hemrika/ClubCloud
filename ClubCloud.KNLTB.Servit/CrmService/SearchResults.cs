using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class SearchResults
	{
		private AppointmentProposal[] proposalsField;
		private TraceInfo traceInfoField;
		public AppointmentProposal[] Proposals
		{
			get
			{
				return this.proposalsField;
			}
			set
			{
				this.proposalsField = value;
			}
		}
		public TraceInfo TraceInfo
		{
			get
			{
				return this.traceInfoField;
			}
			set
			{
				this.traceInfoField = value;
			}
		}
	}
}
