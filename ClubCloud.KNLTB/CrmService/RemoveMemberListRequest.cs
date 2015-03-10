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
	public class RemoveMemberListRequest : Request
	{
		private Guid listIdField;

		private Guid entityIdField;

		[XmlElement] //[XmlElement(Order=1)]
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

		[XmlElement] //[XmlElement(Order=0)]
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

		public RemoveMemberListRequest()
		{
		}
	}
}