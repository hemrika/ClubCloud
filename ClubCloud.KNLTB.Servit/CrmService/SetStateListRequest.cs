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
	public class SetStateListRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.ListState listStateField;

		private int listStatusField;

		[XmlElement] //[XmlElement(Order=0)]
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

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.ListState ListState
		{
			get
			{
				return this.listStateField;
			}
			set
			{
				this.listStateField = value;
				base.RaisePropertyChanged("ListState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int ListStatus
		{
			get
			{
				return this.listStatusField;
			}
			set
			{
				this.listStatusField = value;
				base.RaisePropertyChanged("ListStatus");
			}
		}

		public SetStateListRequest()
		{
		}
	}
}