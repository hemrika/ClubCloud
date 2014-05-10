using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class QualifyMemberListRequest : Request
	{
		private Guid listIdField;
		private Guid[] membersIdField;
		private bool overrideorRemoveField;
		public Guid ListId
		{
			get
			{
				return this.listIdField;
			}
			set
			{
				this.listIdField = value;
			}
		}
		public Guid[] MembersId
		{
			get
			{
				return this.membersIdField;
			}
			set
			{
				this.membersIdField = value;
			}
		}
		public bool OverrideorRemove
		{
			get
			{
				return this.overrideorRemoveField;
			}
			set
			{
				this.overrideorRemoveField = value;
			}
		}
	}
}
