using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
namespace ClubCloud.KNLTB.ServIt.CrmService
{
	[GeneratedCode("System.Xml", "4.0.30319.33440"), DesignerCategory("code"), DebuggerStepThrough, XmlType(Namespace = "http://schemas.microsoft.com/crm/2007/WebServices")]
	[Serializable]
	public class privilege : BusinessEntity
	{
		private CrmNumber accessrightField;
		private CrmBoolean canbebasicField;
		private CrmBoolean canbedeepField;
		private CrmBoolean canbeglobalField;
		private CrmBoolean canbelocalField;
		private string nameField;
		private Key privilegeidField;
		public CrmNumber accessright
		{
			get
			{
				return this.accessrightField;
			}
			set
			{
				this.accessrightField = value;
			}
		}
		public CrmBoolean canbebasic
		{
			get
			{
				return this.canbebasicField;
			}
			set
			{
				this.canbebasicField = value;
			}
		}
		public CrmBoolean canbedeep
		{
			get
			{
				return this.canbedeepField;
			}
			set
			{
				this.canbedeepField = value;
			}
		}
		public CrmBoolean canbeglobal
		{
			get
			{
				return this.canbeglobalField;
			}
			set
			{
				this.canbeglobalField = value;
			}
		}
		public CrmBoolean canbelocal
		{
			get
			{
				return this.canbelocalField;
			}
			set
			{
				this.canbelocalField = value;
			}
		}
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
		public Key privilegeid
		{
			get
			{
				return this.privilegeidField;
			}
			set
			{
				this.privilegeidField = value;
			}
		}
	}
}
