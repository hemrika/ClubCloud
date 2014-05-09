using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class QualifyMemberListRequest : Request
	{
		private Guid listIdField;
		private Guid[] membersIdField;
		private bool overrideorRemoveField;
		[XmlElement(Order = 0)]
		public Guid ListId
		{
			get
			{
				return this.listIdField;
			}
			set
			{
				this.listIdField = value;
				base.RaisePropertyChanged("ListId");
			}
		}
		[XmlArray(Order = 1)]
		public Guid[] MembersId
		{
			get
			{
				return this.membersIdField;
			}
			set
			{
				this.membersIdField = value;
				base.RaisePropertyChanged("MembersId");
			}
		}
		[XmlElement(Order = 2)]
		public bool OverrideorRemove
		{
			get
			{
				return this.overrideorRemoveField;
			}
			set
			{
				this.overrideorRemoveField = value;
				base.RaisePropertyChanged("OverrideorRemove");
			}
		}
	}
}
