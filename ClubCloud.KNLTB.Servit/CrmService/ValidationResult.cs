using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ValidationResult
	{
		private bool validationSuccessField;
		private TraceInfo traceInfoField;
		private Guid activityIdField;
		public bool ValidationSuccess
		{
			get
			{
				return this.validationSuccessField;
			}
			set
			{
				this.validationSuccessField = value;
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
		public Guid ActivityId
		{
			get
			{
				return this.activityIdField;
			}
			set
			{
				this.activityIdField = value;
			}
		}
	}
}
