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
	public class GrantAccessRequest : Request
	{
		private TargetOwned targetField;

		private ClubCloud.KNLTB.ServIt.CrmService.PrincipalAccess principalAccessField;

		[XmlElement] //[XmlElement(Order=1)]
		public ClubCloud.KNLTB.ServIt.CrmService.PrincipalAccess PrincipalAccess
		{
			get
			{
				return this.principalAccessField;
			}
			set
			{
				this.principalAccessField = value;
				base.RaisePropertyChanged("PrincipalAccess");
			}
		}

		[XmlElement] //[XmlElement(Order=0)]
		public TargetOwned Target
		{
			get
			{
				return this.targetField;
			}
			set
			{
				this.targetField = value;
				base.RaisePropertyChanged("Target");
			}
		}

		public GrantAccessRequest()
		{
		}
	}
}