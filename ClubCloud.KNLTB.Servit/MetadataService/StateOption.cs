using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.MetadataService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class StateOption : Option
	{
		private CrmNumber defaultStatusField;
		private string invariantNameField;
		public CrmNumber DefaultStatus
		{
			get
			{
				return this.defaultStatusField;
			}
			set
			{
				this.defaultStatusField = value;
			}
		}
		public string InvariantName
		{
			get
			{
				return this.invariantNameField;
			}
			set
			{
				this.invariantNameField = value;
			}
		}
	}
}
