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
	public class SetStateFaxRequest : Request
	{
		private Guid entityIdField;

		private ClubCloud.KNLTB.ServIt.CrmService.FaxState faxStateField;

		private int faxStatusField;

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
		public ClubCloud.KNLTB.ServIt.CrmService.FaxState FaxState
		{
			get
			{
				return this.faxStateField;
			}
			set
			{
				this.faxStateField = value;
				base.RaisePropertyChanged("FaxState");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public int FaxStatus
		{
			get
			{
				return this.faxStatusField;
			}
			set
			{
				this.faxStatusField = value;
				base.RaisePropertyChanged("FaxStatus");
			}
		}

		public SetStateFaxRequest()
		{
		}
	}
}