using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public class Picklist
	{
		private bool isNullField;
		private bool isNullFieldSpecified;
		private string nameField;
		private int valueField;
		[XmlAttribute]
		public bool IsNull
		{
			get
			{
				return this.isNullField;
			}
			set
			{
				this.isNullField = value;
			}
		}
		[XmlIgnore]
		public bool IsNullSpecified
		{
			get
			{
				return this.isNullFieldSpecified;
			}
			set
			{
				this.isNullFieldSpecified = value;
			}
		}
		[XmlAttribute]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}
		[XmlText]
		public int Value
		{
			get
			{
				return this.valueField;
			}
			set
			{
				this.valueField = value;
			}
		}
	}
}
