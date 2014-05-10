using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlInclude(typeof(Owner)), XmlInclude(typeof(Lookup)), XmlInclude(typeof(Customer)), XmlType(Namespace = "http://schemas.microsoft.com/crm/2006/WebServices")]
	[Serializable]
	public abstract class CrmReference
	{
		private bool isNullField;
		private bool isNullFieldSpecified;
		private string nameField;
		private string typeField;
		private int dscField;
		private bool dscFieldSpecified;
		private Guid valueField;
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
		[XmlAttribute]
		public string type
		{
			get
			{
				return this.typeField;
			}
			set
			{
				this.typeField = value;
			}
		}
		[XmlAttribute]
		public int dsc
		{
			get
			{
				return this.dscField;
			}
			set
			{
				this.dscField = value;
			}
		}
		[XmlIgnore]
		public bool dscSpecified
		{
			get
			{
				return this.dscFieldSpecified;
			}
			set
			{
				this.dscFieldSpecified = value;
			}
		}
		[XmlText]
		public Guid Value
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
