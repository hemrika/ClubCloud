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
	public class DynamicEntity : BusinessEntity
	{
		private Property[] propertiesField;

		private string nameField;

		[XmlAttribute]
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

		[XmlArray] //[XmlArray(Order=0)]
		public Property[] Properties
		{
			get
			{
				return this.propertiesField;
			}
			set
			{
				this.propertiesField = value;
				base.RaisePropertyChanged("Properties");
			}
		}

		public DynamicEntity()
		{
		}
	}
}