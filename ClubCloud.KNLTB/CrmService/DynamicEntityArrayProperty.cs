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
	[XmlType(Namespace="http://schemas.microsoft.com/crm/2006/WebServices")]
	public class DynamicEntityArrayProperty : Property
	{
		private DynamicEntity[] valueField;

		[XmlArray] //[XmlArray(Order=0)]
		[XmlArrayItem(IsNullable=false)]
		public DynamicEntity[] Value
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

		public DynamicEntityArrayProperty()
		{
		}
	}
}