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
	public class RevokeAccessRequest : Request
	{
		private TargetOwned targetField;

		private SecurityPrincipal revokeeField;

		[XmlElement] //[XmlElement(Order=1)]
		public SecurityPrincipal Revokee
		{
			get
			{
				return this.revokeeField;
			}
			set
			{
				this.revokeeField = value;
				base.RaisePropertyChanged("Revokee");
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

		public RevokeAccessRequest()
		{
		}
	}
}