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
	public class SetParentTeamRequest : Request
	{
		private Guid teamIdField;

		private Guid businessIdField;

		[XmlElement] //[XmlElement(Order=1)]
		public Guid BusinessId
		{
			get
			{
				return this.businessIdField;
			}
			set
			{
				this.businessIdField = value;
				base.RaisePropertyChanged("BusinessId");
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

		public SetParentTeamRequest()
		{
		}
	}
}