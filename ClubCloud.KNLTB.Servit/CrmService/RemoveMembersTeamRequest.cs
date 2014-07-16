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
	public class RemoveMembersTeamRequest : Request
	{
		private Guid teamIdField;

		private Guid[] memberIdsField;

		[XmlArray] //[XmlArray(Order=1)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public RemoveMembersTeamRequest()
		{
		}
	}
}