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
	public class resourcegroup : BusinessEntity
	{
		private Lookup businessunitidField;

		private Picklist grouptypecodeField;

		private string nameField;

		private EntityNameReference objecttypecodeField;

		private Lookup organizationidField;

		private Key resourcegroupidField;

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
		public Picklist grouptypecode
		{
			get
			{
				return this.grouptypecodeField;
			}
			set
			{
				this.grouptypecodeField = value;
				base.RaisePropertyChanged("grouptypecode");
			}
		}

		[XmlElement] //[XmlElement(Order=2)]
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

		[XmlElement] //[XmlElement(Order=3)]
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

		[XmlElement] //[XmlElement(Order=4)]
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

		[XmlElement] //[XmlElement(Order=5)]
		public Key resourcegroupid
		{
			get
			{
				return this.resourcegroupidField;
			}
			set
			{
				this.resourcegroupidField = value;
				base.RaisePropertyChanged("resourcegroupid");
			}
		}

		public resourcegroup()
		{
		}
	}
}