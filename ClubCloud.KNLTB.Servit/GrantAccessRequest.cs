using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class GrantAccessRequest : Request
	{
		private TargetOwned targetField;
		private PrincipalAccess principalAccessField;
		[XmlElement(Order = 0)]
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
		[XmlElement(Order = 1)]
		public PrincipalAccess PrincipalAccess
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
	}
}
