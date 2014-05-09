using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RemoveMembersTeamRequest : Request
	{
		private Guid teamIdField;
		private Guid[] memberIdsField;
		[XmlElement(Order = 0)]
		public Guid TeamId
		{
			get
			{
				return this.teamIdField;
			}
			set
			{
				this.teamIdField = value;
				base.RaisePropertyChanged("TeamId");
			}
		}
		[XmlArray(Order = 1)]
		public Guid[] MemberIds
		{
			get
			{
				return this.memberIdsField;
			}
			set
			{
				this.memberIdsField = value;
				base.RaisePropertyChanged("MemberIds");
			}
		}
	}
}
