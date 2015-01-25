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
	public class CopyMembersListRequest : Request
	{
		private Guid sourceListIdField;

		private Guid targetListIdField;

		[XmlElement] //[XmlElement(Order=0)]
		public Guid SourceListId
		{
			get
			{
				return this.sourceListIdField;
			}
			set
			{
				this.sourceListIdField = value;
				base.RaisePropertyChanged("SourceListId");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public Guid TargetListId
		{
			get
			{
				return this.targetListIdField;
			}
			set
			{
				this.targetListIdField = value;
				base.RaisePropertyChanged("TargetListId");
			}
		}

		public CopyMembersListRequest()
		{
		}
	}
}