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
	public class resource : BusinessEntity
	{
		private Lookup businessunitidField;

		private UniqueIdentifier calendaridField;

		private CrmBoolean displayinserviceviewsField;

		private CrmBoolean isdisabledField;

		private string nameField;

		private EntityNameReference objecttypecodeField;

		private Lookup organizationidField;

		private Key resourceidField;

		private Lookup siteidField;

		[XmlElement] //[XmlElement(Order=0)]
		public Lookup businessunitid
		{
			get
			{
				return this.businessunitidField;
			}
			set
			{
				this.businessunitidField = value;
				base.RaisePropertyChanged("businessunitid");
			}
		}

		[XmlElement] //[XmlElement(Order=1)]
		public UniqueIdentifier calendarid
		{
			get
			{
				return this.calendaridField;
			}
			set
			{
				this.calendaridField = value;
				base.RaisePropertyChanged("calendarid");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
		public CrmBoolean displayinserviceviews
		{
			get
			{
				return this.displayinserviceviewsField;
			}
			set
			{
				this.displayinserviceviewsField = value;
				base.RaisePropertyChanged("displayinserviceviews");
			}
		}

		[XmlElement] //[XmlElement(Order=3)]
		public CrmBoolean isdisabled
		{
			get
			{
				return this.isdisabledField;
			}
			set
			{
				this.isdisabledField = value;
				base.RaisePropertyChanged("isdisabled");
			}
		}

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public EntityNameReference objecttypecode
		{
			get
			{
				return this.objecttypecodeField;
			}
			set
			{
				this.objecttypecodeField = value;
				base.RaisePropertyChanged("objecttypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=6)]
		public Lookup organizationid
		{
			get
			{
				return this.organizationidField;
			}
			set
			{
				this.organizationidField = value;
				base.RaisePropertyChanged("organizationid");
			}
		}

		[XmlElement] //[XmlElement(Order=7)]
		public Key resourceid
		{
			get
			{
				return this.resourceidField;
			}
			set
			{
				this.resourceidField = value;
				base.RaisePropertyChanged("resourceid");
			}
		}

		[XmlElement] //[XmlElement(Order=8)]
		public Lookup siteid
		{
			get
			{
				return this.siteidField;
			}
			set
			{
				this.siteidField = value;
				base.RaisePropertyChanged("siteid");
			}
		}

		public resource()
		{
		}
	}
}