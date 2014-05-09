using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class RetrieveLicenseInfoResponse : Response
	{
		private int availableCountField;
		private int grantedLicenseCountField;
		[XmlElement(Order = 0)]
		public int AvailableCount
		{
			get
			{
				return this.availableCountField;
			}
			set
			{
				this.availableCountField = value;
				base.RaisePropertyChanged("AvailableCount");
			}
		}
		[XmlElement(Order = 1)]
		public int GrantedLicenseCount
		{
			get
			{
				return this.grantedLicenseCountField;
			}
			set
			{
				this.grantedLicenseCountField = value;
				base.RaisePropertyChanged("GrantedLicenseCount");
			}
		}
	}
}
