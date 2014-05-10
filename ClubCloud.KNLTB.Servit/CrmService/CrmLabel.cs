using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class CrmLabel
	{
		private LocLabel[] locLabelsField;
		private LocLabel userLocLabelField;
		public LocLabel[] LocLabels
		{
			get
			{
				return this.locLabelsField;
			}
			set
			{
				this.locLabelsField = value;
			}
		}
		public LocLabel UserLocLabel
		{
			get
			{
				return this.userLocLabelField;
			}
			set
			{
				this.userLocLabelField = value;
			}
		}
	}
}
