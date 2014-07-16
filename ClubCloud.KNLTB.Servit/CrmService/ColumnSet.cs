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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/Query")]
	public class ColumnSet : ColumnSetBase
	{
		private string[] attributesField;

		[XmlArray] //[XmlArray(Order=0)]
		[XmlArrayItem("Attribute", IsNullable=false)]
		public string[] Attributes
		{
			get
			{
				return this.attributesField;
			}
			set
			{
				this.attributesField = value;
				base.RaisePropertyChanged("Attributes");
			}
		}

		public ColumnSet()
		{
		}
	}
}