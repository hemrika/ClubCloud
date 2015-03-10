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
	public class OfflineDataOptionalParameter : OptionalParameter
	{
		private string nameField;

		private string valueField;

		[XmlElement] //[XmlElement(Order=0)]
		public string Name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("Name");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public string Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
				base.RaisePropertyChanged("Value");
			}
		}

		public OfflineDataOptionalParameter()
		{
		}
	}
}