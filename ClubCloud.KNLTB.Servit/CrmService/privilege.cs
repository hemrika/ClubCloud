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
	public class privilege : BusinessEntity
	{
		private CrmNumber accessrightField;

		private CrmBoolean canbebasicField;

		private CrmBoolean canbedeepField;

		private CrmBoolean canbeglobalField;

		private CrmBoolean canbelocalField;

		private string nameField;

		private Key privilegeidField;

		[XmlElement] //[XmlElement(Order=0)]
		public CrmNumber accessright
		{
			get
			{
				return this.accessrightField;
			}
			set
			{
				this.accessrightField = value;
				base.RaisePropertyChanged("accessright");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public CrmBoolean canbebasic
		{
			get
			{
				return this.canbebasicField;
			}
			set
			{
				this.canbebasicField = value;
				base.RaisePropertyChanged("canbebasic");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmBoolean canbedeep
		{
			get
			{
				return this.canbedeepField;
			}
			set
			{
				this.canbedeepField = value;
				base.RaisePropertyChanged("canbedeep");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmBoolean canbeglobal
		{
			get
			{
				return this.canbeglobalField;
			}
			set
			{
				this.canbeglobalField = value;
				base.RaisePropertyChanged("canbeglobal");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
		public CrmBoolean canbelocal
		{
			get
			{
				return this.canbelocalField;
			}
			set
			{
				this.canbelocalField = value;
				base.RaisePropertyChanged("canbelocal");
			}
		}

		[XmlElement] //[XmlElement(Order=5)]
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
				base.RaisePropertyChanged("name");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Key privilegeid
		{
			get
			{
				return this.privilegeidField;
			}
			set
			{
				this.privilegeidField = value;
				base.RaisePropertyChanged("privilegeid");
			}
		}

		public privilege()
		{
		}
	}
}