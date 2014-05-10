using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/Scheduling")]
	[Serializable]
	public class ProposalParty
	{
		private Guid resourceIdField;
		private Guid resourceSpecIdField;
		private string displayNameField;
		private string entityNameField;
		private double effortRequiredField;
		public Guid ResourceId
		{
			get
			{
				return this.resourceIdField;
			}
			set
			{
				this.resourceIdField = value;
			}
		}
		public Guid ResourceSpecId
		{
			get
			{
				return this.resourceSpecIdField;
			}
			set
			{
				this.resourceSpecIdField = value;
			}
		}
		public string DisplayName
		{
			get
			{
				return this.displayNameField;
			}
			set
			{
				this.displayNameField = value;
			}
		}
		public string EntityName
		{
			get
			{
				return this.entityNameField;
			}
			set
			{
				this.entityNameField = value;
			}
		}
		public double EffortRequired
		{
			get
			{
				return this.effortRequiredField;
			}
			set
			{
				this.effortRequiredField = value;
			}
		}
	}
}
